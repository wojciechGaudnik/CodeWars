using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6WhichAreIn
    {
        public static void Main(string[] args)
        {
            string[] a1 = new string[] { "arp", "live", "strong" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };

            var test1 = "test";
            var test2 = "aesta";
            Console.WriteLine(test2.Contains(test1));
        }

        public static string[] inArray(string[] array1, string[] array2)
        {
            return array1
                .Where(s1 => array2
                    .Any(s2 => s2.Contains(s1)))
                .OrderBy(s => s)
                .ToArray();
        }
    }
}