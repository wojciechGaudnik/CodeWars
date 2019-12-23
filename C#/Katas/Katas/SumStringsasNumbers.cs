using System;
using System.Numerics;

namespace Katas
{
    public class SumStringsasNumbers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(sumStrings("50095301248058391139327916261", "81055900096023504197206408605"));
        }

        public static string sumStrings(string a, string b)
        {
            if(a == "") a = "0";
            if(b == "") b = "0";
            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        }
    }
}