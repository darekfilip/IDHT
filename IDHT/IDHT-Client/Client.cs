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
			if (args.Length >= 3 && args[0].Equals("-p"))
			{
				Console.WriteLine("PUT("+args[1] + " -> "+args[2]+")");
				dhtnode.insertDHT(args[1], args[2]);
				Console.WriteLine("GET("+args[1]+") -> "+dhtnode.searchDHT(args[1]));
			}
			else if (args.Length >= 2 && args[0].Equals("-g"))
			{
				Console.WriteLine("GET("+args[1]+") -> "+dhtnode.searchDHT(args[1]));
			}
			else
			{
				Console.WriteLine("incorrect parameters");
			}
			return 0;
		}
	}
}

