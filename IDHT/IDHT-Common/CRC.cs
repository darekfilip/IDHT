using System;
using System.Security.Cryptography;

namespace IDHTCommon
{
	public class CRC
	{
		public static int getCRC(string inputString)
		{
			Crc32 crc = new Crc32();
			crc.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(inputString));
			return (int)crc.CrcValue;
		}
	}
}

