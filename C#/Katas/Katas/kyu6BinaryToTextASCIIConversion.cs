using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas
{
    public class kyu6BinaryToTextASCIIConversion
    {
        public static string BinaryToString(string binary)
        {
            if(binary == "") return binary;
            return Encoding.ASCII
                .GetString(Regex.Split(binary, @"(........)")
                    .Where(s => s != "")
                    .Select(s => Convert.ToByte(s, 2))
                    .ToArray());
        }
    }
}