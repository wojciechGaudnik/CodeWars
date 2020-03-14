using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class kuy6BackspacesInString
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine(CleanString("#a#bc#d"));
            // Console.WriteLine(CleanString("a#bc#d"));
            // Console.WriteLine(CleanString("abc#d##c"));
            // Console.WriteLine(CleanString("abc##d######"));
            Console.WriteLine(CleanString("y!##s###F##$xqh##Qm####v#k^)aL7####n#Q#R##########b2r##F##T#Mr"));
        }

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