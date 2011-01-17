using System;

using Ice;
using IceBox;

namespace IDHTServices
{
	public class Server : Service
	{
		private ObjectAdapter _adapter;

		private DHTNodeI _node;
		
		public void start(string name, Communicator communicator, string[] args)
		{
			bool isMasterNode = communicator.getProperties().getPropertyAsIntWithDefault("IDHT.Master",0) == 1;
			string identity = "IDHTNode-"+name;
			
			_node = new DHTNodeI(identity, isMasterNode);
			_adapter = communicator.createObjectAdapter(name);
			_adapter.add(_node, Ice.Util.stringToIdentity("IDHTNode"));
			_adapter.add(_node, Ice.Util.stringToIdentity(identity));
			_adapter.activate();
		}
		
		public void stop()
		{
			_adapter.deactivate();
			_node.shutDown();
		}

	}
}

