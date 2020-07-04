using System;
using System.Linq;
using System.Net;

namespace Katas
{
    public class kyu5CountIPAddresses
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IpsBetween("10.0.0.0", "10.0.0.50"));

        }

        public static long IpsBetween(string start, string end)
        {
            return ConvertIPtoLong(end) - ConvertIPtoLong(start);
        }

        private static long ConvertIPtoLong(string ip) =>
            BitConverter.ToInt32(IPAddress.Parse(ip).GetAddressBytes().Reverse().ToArray(), 0);
    }
}