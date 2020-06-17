using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    public class kyu6Binaries
    {
        private static Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            {"0", "10"},
            {"1", "11"},
            {"2", "0110"},
            {"3", "0111"},
            {"4", "001100"},
            {"5", "001101"},
            {"6", "001110"},
            {"7", "001111"},
            {"8", "00011000"},
            {"9", "00011001"},
        };

        public static string Code(string strng)
        {
            return string.Join("", strng.Select(s => dict.GetValueOrDefault(char.ToString(s))).ToArray());
        }

        public static string Decode(string str)
        {
            var answer = new StringBuilder();
            var number = "";
            foreach (var c in str)
            {
                number += c;
                foreach (var kv in dict.Where(kv => kv.Value == number))
                {
                    answer.Append(kv.Key);
                    number = "";
                    break;
                }
            }
            return answer.ToString();
        }
    }
}