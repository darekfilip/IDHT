using System;
using System.Threading;
using System.Collections.Generic;

using Ice;

using IDHT;
using IDHTCommon;

namespace IDHTServices
{
	public class DHTNodeI : DHTNodeDisp_
	{	
		private range subtreeRange;
		
		private Communicator _communicator;
		
		private List<range> ranges = new List<range>();
		
		private string _parent;
		
		private string _nodeName;
		
		private List<nodeConf> childs = new List<nodeConf>();
		
		private Dictionary<int, List<keyvaluepair>> values = new Dictionary<int, List<keyvaluepair>>();
		
		Boolean IsDisconnecting { get; set; }
		
		// redukuje ranges
		// tzn z 2 A-B oraz B-C robi A-C itp..
		private void reduceRanges()
		{
			List<range> newRanges = new List<range>();
			for (int i = 0; i < ranges.Count; ++i)
			{
				range r = ranges[i];
				bool changed = true;
				while (changed) 
				{
					changed = false;
					for (int j = i + 1; j < ranges.Count; ) 
					{
						if (ranges[j].min == r.max)
						{
							r.max = ranges[j].max;
							ranges.RemoveAt(j);
							changed = true;
						} 
						else if (ranges[j].max == r.min)
						{
							r.max = ranges[j].max;
							ranges.RemoveAt(j);
							changed = true;
						}
						else 
						{
							++j;
						}
					}
				}
				newRanges.Add(r);
			}
			ranges = newRanges;
		}
		
		public override void masterDisconnected (string id, string connectTo, range[] newRanges, nodeConf[] childRanges, Ice.Current current__)
		{
			lock (ranges)
			{
				_parent = connectTo;
				ranges.AddRange(newRanges);
				foreach (nodeConf nc in childRanges)
				{
					nc.parentNode = _nodeName;
				}
				childs.AddRange(childRanges);
				reduceRanges();
			}
		}
		
		public override nodeConf newConnected (string id, Ice.Current current__)
		{
			if (IsDisconnecting)
			{
				throw new Exception("Node shutting down.");
			}
			lock (ranges)
			{
				nodeConf nc = new nodeConf();
				nc.parentNode = _nodeName;
				if (ranges.Count > 1)
				{
					nc.min = ranges[0].min;
					nc.max = ranges[0].max;
					ranges.RemoveAt(0);
				}
				else 
				{
					nc.min = ranges[0].min;
					nc.max = (ranges[0].min + ranges[0].max)/2;
					range r = ranges[0];
					r.min = nc.max + 1;
					ranges[0] = r;
				}
				
				lock (values)
				{
					List<keyvaluepair> elems = new List<keyvaluepair>();
					foreach (int crc in new List<int>(values.Keys))
					{
						if (crc >= nc.min && crc <= nc.max) 
						{
							elems.AddRange(values[crc]);
							values.Remove(crc);
						}
					}
					nc.elems = elems.ToArray();
				}
				return nc;
			}
		}
		
		
		public override void slaveDisconnected (string id, Ice.Current current__)
		{
			lock (ranges)
			{
				nodeConf removedNode = null;
				foreach (nodeConf nc in childs)
				{
					if (nc.nodeId == id)
					{
						removedNode = nc;
					}
				}
				if (removedNode != null)
				{
					ranges.Add(new range(removedNode.min, removedNode.max));
					childs.Remove(removedNode);
					reduceRanges();
				}
				else 
				{
					Console.WriteLine("Struct fail: {0} is not a child of {1}", id, _nodeName); 
				}
			}
		}		
		
		public override string seatchDHT (string key, Ice.Current current__)
		{
			if (IsDisconnecting)
			{
				throw new Exception("Node shutting down");
			}
			int crc = CRC.getCRC(key);
			if (crc <= subtreeRange.max && crc >= subtreeRange.min)
			{
				// szukamy w swoich
				List<range> myRanges = new List<range>(ranges);
				foreach (range r in myRanges)
				{
					if (r.max >= crc && r.min <= crc)
					{
						lock (values)
						{
							if (values.ContainsKey(crc))
							{
								List<keyvaluepair> vals = values[crc];
								foreach (keyvaluepair kvp in vals)
								{
									if (kvp.key == key)
									{
										return kvp.value;
									}
								}
							}
						}
						return null;
					}
				}
				
				// szukamy u potomkow
				bool error = true;
				while (error)
				{
					error = false;
					try
					{
						List<nodeConf> childNodes = new List<nodeConf>(childs);
						foreach (nodeConf nc in childNodes)
						{
							if (nc.min <= crc && nc.max >= crc)
							{
								// TODO
								return null;
							}
						}
					}
					catch (Exception)
					{
						error = true;
						Thread.Sleep(100);
					}
				}
				return null;
			}
			else
			{
				bool error = true;
				while (error)
				{
					error = false;
					try
					{
						// TODO: odpytanie rodzica
						return null;
					}
					catch (Exception)
					{
						error = true;
						Thread.Sleep(100);
					}
				}
			}
			return null;
		}
		
		
		public override void insertDHT (string key, string val, Ice.Current current__)
		{
			if (IsDisconnecting)
			{
				throw new Exception("Node shutting down.");
			}
			int crc = CRC.getCRC(key);
			if (crc <= subtreeRange.max && crc >= subtreeRange.min) 
			{
				// wyszukujemy wśród dzieci
				bool error = true;
				while (error)
				{
					error = false;
					List<nodeConf> _ranges = null;
					lock (ranges)
					{
						_ranges = new List<nodeConf>(childs);
					}
					try 
					{
						foreach (nodeConf n in _ranges)
						{
							if (n.min <= crc && n.max >= crc)
							{
								// TODO: sprobowac odebrac wartosc
							}
						}
					}
					catch (Exception)
					{
						// wystapil blad - czekamy i ponawiamy
						error = true;
						Thread.Sleep(100);
					}
				}
			}
			else
			{
				bool error = true;
				while (error)
				{
					error = false;
					try
					{
						//TODO: odpytanie rodzica
					}
					catch (Exception)
					{
						error = true;
						Thread.Sleep(100);
					}
				}
			}
		}
		
		public void shutDown()
		{
			
		}
		
		private DHTNodePrx getParentNode()
		{
			
		}
		
		public DHTNodeI (string nodeName, bool isMaster, Communicator communicator)
		{
			bool configured = false;
			IsDisconnecting = false;
			
			if (isMaster)
			{
				// TODO: sprawdzic czy sa jakies wezly jak tak to podlaczyc
				// a nie tworzyc nowe
				subtreeRange = new range(int.MinValue, int.MaxValue);
				_nodeName = nodeName;
				_parent = null;
				ranges.Add(subtreeRange);
				
				configured = true;
			}
			
			if (!configured) 
			{
				// TODO: polaczyc sie z losowym wezlem w grupie replikacji i pobrac konfiguracje
			}
		}
	}
}

