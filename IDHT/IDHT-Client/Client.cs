using System;

using Ice;

using IDHT;
using IDHTCommon;

namespace IDHTClient
{
	public class Client : Application
	{
		public override int run(string[] args)
		{
			// TODO: jakas petelke for
			// wsadzic losowych 1000 elementow i je wyciagac 
			// wsadzac w sposob val = f(key)
			// zrobic veryfikacje
			ObjectPrx prx = communicator().stringToProxy(Constants.SERVICE_NAME);
			DHTNodePrx dhtnode = DHTNodePrxHelper.checkedCast(prx);
			if (dhtnode == null)
			{
				throw new ApplicationException("Wrong proxy");
			}
			dhtnode.insertDHT("darek", "value for darek");
			Console.WriteLine(dhtnode.seatchDHT("darek"));
			return 0;
		}
	}
}

