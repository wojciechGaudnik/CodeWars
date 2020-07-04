using System;
using System.Linq;

namespace Katas
{
    public class kyu5MergedStringChecker
    {
        public static bool isMerge(string s, string part1, string part2)
        {
            if (s.Length <= 0) return s.Length == 0 && part1.Length == 0 && part2.Length == 0;
            if (part1.Length > 0 && part2.Length > 0 && s[0] == part1[0] && s[0] == part2[0])
            {
                return isMerge(s.Substring(1), part1.Substring(1), part2) ||
                       isMerge(s.Substring(1), part1, part2.Substring(1));
            }
            if (part1.Length > 0) if(s[0] == part1[0]) return isMerge(s.Substring(1), part1.Substring(1), part2);
            if (part2.Length <= 0) return s.Length == 0 && part1.Length == 0 && part2.Length == 0;
            if(s[0] == part2[0]) return isMerge(s.Substring(1), part1, part2.Substring(1));
            return s.Length == 0 && part1.Length == 0 && part2.Length == 0;
        }


        public static bool isMerge1(string s, string part1, string part2)
        {
            Console.WriteLine("--->" + s + " " + part1 + " " + part2 + "<---");
            if(part1 + part2 == s) return true;
            if(string.Join("", part1.Zip(part2, (a, b) => "" + a + b)) == s) return true;
            if(string.Join("", part2.Zip(part1, (a, b) => "" + a + b)) == s) return true;


            return false;
        }


    }
}