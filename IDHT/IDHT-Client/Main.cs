using System;

namespace IDHTClient
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Client c = new Client();
			Environment.Exit(c.main(args));
		}
	}
}

