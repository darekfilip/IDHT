using System;

using Ice;
using IceBox;

using IDHTCommon;

namespace IDHTServices
{
	public class Server : IceBox.Service
	{
		private ObjectAdapter _adapter;

		private DHTNodeI _node;
		
		public void start(string name, Ice.Communicator communicator,  string[] args)
		{
			Console.WriteLine("STARTING Service: {0}", name);
			string prop =  communicator.getProperties().getProperty("IDHT.Master");
			bool isMasterNode = (prop == null)? false: prop.Equals("1");
			if (isMasterNode)
			{
				Console.WriteLine("Is master node");
			}
			_node = new DHTNodeI(name, isMasterNode, communicator);
			_adapter = communicator.createObjectAdapter(name);
			_adapter.add(_node, Ice.Util.stringToIdentity(Constants.SERVICE_NAME));
			_adapter.activate();
		}

		public void stop()
		{
			_adapter.deactivate();
			_node.shutDown();
		}

	}
}

