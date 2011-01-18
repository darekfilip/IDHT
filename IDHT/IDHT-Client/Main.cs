using System;

namespace IDHTClient
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Client c = new Client();
			c.run(args);
		}
	}
}

