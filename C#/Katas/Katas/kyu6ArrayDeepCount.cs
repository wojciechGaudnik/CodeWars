using System;
using System.Collections;
using System.Linq;

namespace Katas
{
    public class kyu6ArrayDeepCount
    {
        private static object[] Basic_Test_Cases = new object[]
        {
            new object[]
            {
                new object[] {},
                0
            },
            new object[]
            {
                new object[] {1, 2, 3},
                3
            },
            new object[]
            {
                new object[] {"x", "y", new object[] {"z"}},
                4
            },
            new object[]
            {
                new object[] {1, 2, new object[] {3, 4, new object[] {5}}},
                7
            },
            new object[]
            {
                new object[] { new object[] { new object[] { new object[] { new object[] { new object[] { new object[] { new object[] { new object[] {}}}}}}}}},
                8
            }
        };

        public static void Main(string[] args)
        {
            Console.WriteLine(DeepCount(new object[] {1, 2, 3}));
            Console.WriteLine(DeepCount(new object[] {"x", "y", new object[] {"z"}}));
            // Console.WriteLine(DeepCount(Basic_Test_Cases[4]));
        }

        public static int DeepCount(object a)
        {
            var sum = 0;
            if (!(a is IEnumerable test) || a is string) return sum;
            return ((object[]) test).Length + ((object[]) test).Sum(DeepCount);
        }


    }
}