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
		
		private object _discLock = new object();
		
		private int servNum = 0;
		
		private DHTNodePrx getNodeProxy(string id)
		{
			ObjectPrx prx = _communicator.stringToProxy(Constants.SERVICE_NAME + '@' + id);
			return DHTNodePrxHelper.checkedCast(prx); 
		}
		
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
		
		public override void masterDisconnected (string connectTo, range subtree, range[] newRanges, nodeConf[] childRanges, Ice.Current current__)
		{
			lock (ranges)
			{
				_parent = connectTo;
				if (connectTo == null) // jestem nowy rootem dla tego poddrzewa
				{
					subtreeRange = subtree;
				}
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
				throw new System.Exception("Node shutting down.");
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
		
		
		public override void slaveDisconnected (string id, range[] newRanges, nodeConf[] childRanges, Ice.Current current__)
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
					foreach (range r in newRanges)
					{
						ranges.Add(r);
					}
					reduceRanges();
					foreach (nodeConf nc in childRanges)
					{
						childs.Add(nc);
					}
				}
				else 
				{
					Console.WriteLine("Struct fail: {0} is not a child of {1}", id, _nodeName); 
				}
			}
		}		
		
		private void enter()
		{
			lock (_discLock)
			{
				if (IsDisconnecting)
				{
					throw new System.Exception("Node shutting down");
				}
				++servNum;
			}
		}
		
		private void leave()
		{
			lock (_discLock)
			{
				--servNum;
				if (servNum == 0) 
				{
					Monitor.Pulse(_discLock);
				}
			}
		}
		
		public override string searchDHT (string key, Ice.Current current__)
		{
			enter();
			
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
										leave();
										return kvp.value;
									}
								}
							}
						}
						leave();
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
								DHTNodePrx prx = getNodeProxy(nc.nodeId);
								if (prx == null)
								{
									// jesli jest w dzieciach a nie osiagalna 
									// to sie wyrejestrowuje
									throw new System.Exception("Node not present!");
								}
								leave();
								return prx.searchDHT(key);
							}
						}
					}
					catch (System.Exception)
					{
						error = true;
						Thread.Sleep(100);
					}
				}
				leave();
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
						DHTNodePrx prx = getNodeProxy(_parent);
						if (prx == null)
						{
							throw new System.Exception("Parent not present");
						}
						leave();
						return prx.searchDHT(key);
					}
					catch (System.Exception)
					{
						error = true;
						Thread.Sleep(100);
					}
				}
			}
			leave();
			return null;
		}
		
		
		public override void insertDHT (string key, string val, Ice.Current current__)
		{
			enter();
			int crc = CRC.getCRC(key);
			if (crc <= subtreeRange.max && crc >= subtreeRange.min) 
			{
				// wyszukujemy wśród dzieci
				bool error = true;
				bool inserted = false;
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
								DHTNodePrx prx = getNodeProxy(n.nodeId);
								if (prx == null)
								{
									throw new System.Exception("Node not present");
								}
								prx.insertDHT(key, val);
								inserted = true;
								break;
							}
						}
					}
					catch (System.Exception)
					{
						// wystapil blad - czekamy i ponawiamy
						error = true;
						inserted = false;
						Thread.Sleep(100);
					}
				}
				if (!inserted)
				{
					lock (values)
					{
						if (values.ContainsKey(crc))
						{
							values[crc].Add(new keyvaluepair(key, val));
						}
						else
						{
							values[crc] = new List<keyvaluepair>();
							values[crc].Add(new keyvaluepair(key, val));
						}
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
						DHTNodePrx parent = getNodeProxy(_parent);
						parent.insertDHT(key, val);
					}
					catch (System.Exception)
					{
						error = true;
						Thread.Sleep(100);
					}
				}
			}
			leave();
		}
		
		public void shutDown()
		{
			IsDisconnecting = true;
			lock (_discLock)
			{
				while (servNum > 0) 
				{
					Monitor.Wait(_discLock);
				}
			}
			if (_parent == null) // jestem rootem - wyznaczam jednego z moich potomkow na roota
			{
				string newRoot = null;
				foreach (nodeConf ch in childs)
				{
					DHTNodePrx child = getNodeProxy(ch.nodeId);
					if (newRoot == null)
					{
						child.masterDisconnected(newRoot, subtreeRange, ranges.ToArray(), childs.ToArray()); 
						newRoot = ch.nodeId;
					} 
					else 
					{
						child.masterDisconnected(newRoot, new range(), new range[0], new nodeConf[0]);
					}
				}
			}
			else // nie jestem rootem - podlaczam moich potomkow do roota
			{
				foreach (nodeConf ch in childs)
				{
					DHTNodePrx child = getNodeProxy(ch.nodeId);
					child.masterDisconnected(_parent, new range(), new range[0], new nodeConf[0]);
				}
				DHTNodePrx prx = getNodeProxy(_parent);
				prx.slaveDisconnected(_nodeName, ranges.ToArray(), childs.ToArray());
			}
		}
		
		public DHTNodeI (string nodeName, bool isMaster, Communicator communicator)
		{

			IsDisconnecting = false;
			_communicator = communicator;
			_nodeName = nodeName;
	
			if (isMaster)
			{
				Console.WriteLine("No other node - became master.");
				subtreeRange = new range(int.MinValue, int.MaxValue);
				_parent = null;
				ranges.Add(subtreeRange);
				return;
			}
		
			while (true)
			{
				Console.WriteLine("Connecting...");
				ObjectPrx oprx = communicator.stringToProxy(Constants.SERVICE_NAME);
				DHTNodePrx nprx =  DHTNodePrxHelper.checkedCast(oprx);
				if (nprx != null)
				{
					try 
					{
						Console.WriteLine("Getting conf from parent...");
						nodeConf my_node = nprx.newConnected(nodeName);
						subtreeRange = new range(my_node.min, my_node.max);
						_parent = my_node.parentNode;
						Console.WriteLine("Node {0} parent: {1}",nodeName, _parent);
						Console.WriteLine("DHTNodeI created");
						return;
					}
					catch (System.Exception e)
					{
						Console.Error.WriteLine(e.StackTrace);
					}
				}
				else
				{
					Console.WriteLine("Wait for master");
					Thread.Sleep(500);	
				}
			}
			
		}
	}
}