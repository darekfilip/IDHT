using System;

using Ice;
using IceBox;

using IDHTCommon;

namespace IDHTServices
{
	public class Server : Service
	{
		private ObjectAdapter _adapter;

		private DHTNodeI _node;
		
		public void start(string name, Communicator communicator, string[] args)
		{
			bool isMasterNode = communicator().getProperties().getPropertyAsIntWithDefault("IDHT.Master",0) == 1;
			_node = new DHTNodeI(name, isMasterNode);
			_adapter = communicator().createObjectAdapter(name);
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

