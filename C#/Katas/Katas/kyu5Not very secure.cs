using System;
using System.Text.RegularExpressions;

namespace Katas
{
    public class kyu5Not_very_secure
    {
        public static bool Alphanumeric(string str)
        {
            Console.WriteLine(str);
            if (str.Contains('_')) return false;
            return (new Regex("^[a-zA-z\\d]+$")).IsMatch(str);
        }

    }
}