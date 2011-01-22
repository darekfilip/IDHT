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
			ObjectPrx prx = communicator().stringToProxy(Constants.SERVICE_NAME);
			DHTNodePrx dhtnode = DHTNodePrxHelper.checkedCast(prx);
			if (dhtnode == null)
			{
				throw new ApplicationException("Wrong proxy");
			}
			if (args.Length >= 4 && args[1].Equals("-p"))
			{
				Console.WriteLine("PUT("+args[2] + " -> "+args[3]+") ...");
				dhtnode.insertDHT(args[2], args[3]);
				Console.WriteLine("GET("+args[2]+") -> "+dhtnode.searchDHT(args[2]));
			}
			else if (args.Length >= 3 && args[1].Equals("-g"))
			{
				Console.WriteLine("GET("+args[2]+") -> "+dhtnode.searchDHT(args[2]));
			}
			return 0;
		}
	}
}

