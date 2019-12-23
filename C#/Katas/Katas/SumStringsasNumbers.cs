using System.Numerics;

namespace Katas
{
    public class SumStringsasNumbers
    {
        public static string sumStrings(string a, string b)
        {
            if(a == "") a = "0";
            if(b == "") b = "0";
            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        }
    }
}