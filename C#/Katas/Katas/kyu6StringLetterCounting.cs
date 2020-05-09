using System;
using System.Linq;

namespace Katas
{
    public class kyu6StringLetterCounting
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(StringLetterCount("1a1b1c1d3e1f1g2h1i1j1k1l1m1n4o1p1q2r1s2t2u1v1w1x1y1z"));
            Console.WriteLine(StringLetterCount("The quick brown fox jumps over the lazy dog."));
        }

        public static string StringLetterCount(string str)
        {
            var test = string.Join("", str
                .Where(char.IsLetter)
                .Select(char.ToLower)
                .GroupBy(c => c)
                .Select(group => new {sign = group.Key, size = group.Count()})
                .OrderBy(g => g.sign)
                .Select(g => string.Join("", g.size + g.sign.ToString())));
            return test;
        }

    }
}