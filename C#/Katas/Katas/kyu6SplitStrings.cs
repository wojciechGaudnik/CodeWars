using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class kyu6SplitStrings
    {
        public static string[] Solution(string str)
        {
            str = (str.Length % 2 == 1)? str + "_" : str;
            return Regex.Matches(str, "(..)").Select(m => m.Value).ToArray();
        }
    }
}