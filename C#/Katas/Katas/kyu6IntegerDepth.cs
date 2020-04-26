using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6IntegerDepth
    {
        public static void Main(string[] args)
        {
            var test = new HashSet<char>();
            var testList = new List<char>() {'a', 'b', 'c', 'c'};
            // var concat = test.Concat(testList);
            // test.UnionWith(testList);
            // Console.WriteLine(string.Join(", ", test));
            Console.WriteLine(ComputeDepth(1));
            Console.WriteLine(ComputeDepth(42));
        }

        public static int ComputeDepth(int n)
        {
            var set = new HashSet<char>();
            for (var i = 1;; i++)
            {
                set.UnionWith((n * i).ToString().ToHashSet());
                if (set.Count == 10) return i;
            }
        }
    }
}