using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas
{
    public class DecodeTheMorseCodeAdvanced
    {

        public static string DecodeBits(string bits)
        {
            var listBits = Regex.Matches(bits.Trim(), "(.)\\1*");
            var answer = new StringBuilder();
            var minMatch = listBits
                .GroupBy(m => m.ToString().Length)
                .Select(mg => mg.Key)
                .Min();

            if (listBits.Select(s => s.ToString()).Count(s => s  == "111") == 1
                && bits.Select(b => b).Count(b => b == '1') == 3)
            {
                return ".";
            }

            foreach (var match in listBits)
            {
                var sign = match.ToString();
                if (sign.Length % minMatch == 0)
                {
                    switch (sign[0])
                    {
                        case '1' when sign.Length == minMatch:
                            answer.Append(".");
                            break;
                        case '0' when sign.Length == minMatch:
                            break;
                        case '0' when sign.Length == minMatch * 3:
                            answer.Append(" ");
                            break;
                        case '1' when sign.Length == minMatch * 3:
                            answer.Append("-");
                            break;
                        case '0' when sign.Length == minMatch * 7:
                            answer.Append("  ");
                            break;
                    }
                }
            }
            return answer.ToString().Trim();
        }
    }
}