using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6GoodvsEvil
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GoodVsEvil("1 1 1 1 1 1", "0 1 1 1 1 1 1"));
        }


        public static string GoodVsEvil(string good, string evil)
        {
            var goodTeam = new List<int>(){1, 2, 3, 3, 4, 10};
            var evilTeam = new List<int>(){1, 2, 2, 2, 3, 5, 10};

            var goodCount = good
                .Split(" ")
                .Select(int.Parse)
                .Zip(goodTeam, (s, i) => new {s, i})
                .Select(z => z.s * z.i)
                .Sum();

            var evilCount = evil
                .Split(" ")
                .Select(int.Parse)
                .Zip(evilTeam, (s, i) => new {s, i})
                .Select(z => z.s * z.i)
                .Sum();
            if (goodCount == evilCount)
            {
                return "Battle Result: No victor on this battle field";
            }

            return goodCount < evilCount
                ? "Battle Result: Evil eradicates all trace of Good"
                : "Battle Result: Good triumphs over Evil";
        }

    }
}