using System;
using System.Text;

namespace Katas
{
    public class kyu5Int32ToIPv4
    {
        public static string UInt32ToIP(uint ip)
        {
            var binary = Convert.ToString(ip, 2);
            binary = new string('0', 8 * 4 - binary.Length) + binary;
            var answer = new StringBuilder();
            for (var i = 0; i < 32; i += 8)
            {
                answer.Append(Convert.ToInt32(binary.Substring(i, 8), 2) + ".");
            }
            return answer.ToString().Trim('.');
        }
    }
}