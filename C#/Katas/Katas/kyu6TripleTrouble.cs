using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class kyu6TripleTrouble
    {
        public static int TripleDouble(long num1, long num2)
        {
            var num1Matches = Regex.Matches(num1.ToString(), "(\\d)\\1\\1").Select(m => m.Value).ToList();
            var num2Matches = Regex.Matches(num2.ToString(), "(\\d)\\1").Select(c => c.Value).ToList();
            return num1Matches.Any(one1 => num2Matches.Any(one2 => one1[0] == one2[0])) ? 1 : 0;
        }
    }
}