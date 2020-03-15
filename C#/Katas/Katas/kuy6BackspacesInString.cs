using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class kuy6BackspacesInString
    {
        public static string CleanString(string s)
        {
            // Console.WriteLine(s);

            while (s.Contains('#'))
            {
                s = Regex.Replace(s, "^#*", "");
                s = Regex.Replace(s, "[^#.]#", "");
                if (s.All(c => c == '#')) return "";
            }
            return s;
        }
    }
}