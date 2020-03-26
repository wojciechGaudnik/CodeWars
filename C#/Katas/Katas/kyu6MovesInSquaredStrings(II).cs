using System;
using System.Linq;

namespace Katas
{
    public class kyu6MovesInSquaredStrings_II_
    {
        public static string Rot(string strng) {
            return string.
                Join("\n", strng
                    .Split("\n")
                    .Reverse()
                    .Select(w => new String(w.Reverse().ToArray()))
                    .ToList());;
        }
        public static string SelfieAndRot(string strng)
        {
            var first = string.Join("\n", strng.Split("\n").Select(w => w + new String('.', w.Length)).ToArray());
            return first + "\n" + Rot(first);
        }
        public static string Oper(Func<string, string> fct, string s)
        {
            return fct(s);
        }
    }
}