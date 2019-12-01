using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas
{
    public class Decoding
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Decode("1273409kuqhkoynvvknsdwljantzkpnmfgf"));
            Console.WriteLine(Decode("6015ekx"));
        }

        public static String Decode(String r)
        {
            MatchCollection data = Regex.Matches(r, "\\d+|\\w+");
            int num = int.Parse(data[0].ToString());
            string coded = data[1].ToString();
            StringBuilder decoded = new StringBuilder();

            foreach (char code in coded)
            {
                int test = 0;
                for (int i = 0; i < 26; i++)
                {
                    if ((i * num) % 26 == (code - 'a') && test++ == 0)
                    {
                        decoded.Append((char)(i + 'a'));
                    }
                }
                if(test != 1) return "Impossible to decode";
            }
            return decoded.ToString();
        }
    }
}