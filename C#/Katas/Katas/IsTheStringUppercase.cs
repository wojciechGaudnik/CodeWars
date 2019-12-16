using System;
using System.Text.RegularExpressions;

namespace Katas
{
    public static class IsTheStringUppercase
    {
        static void Main(string[] args)
        {
            var stringMy = "gztxxxxxggggggggggggsssssssbbbbbeeeeeeehhhmmmmmmmitttttttlllllhkppppp";
            // (.)\1+(.){1}(.)\1+
        }

        static int CountGroup(string s)
        {
            var start = 0;
            var next = 0;
            var previous = ' ';
            foreach (var c in s.ToCharArray())
            {
                if (c == previous) start++;
                if (c != previous && start >= 2) previous = c;
                // if()
            }
            return 666;
        }


        public static bool IsUpperCase(this string text)
        {
            foreach (char w in text.ToCharArray())
            {
                if (Char.IsLower(w)) return false;
            }
            return true;
        }
    }
}