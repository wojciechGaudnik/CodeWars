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

        public static int DeepCount(object a)
        {
            var sum = 0;
            if (a is IEnumerable test && !(a is String))
            {
                sum = ((object[])test).Length;
                foreach (var one in (object[])test)
                {
                    sum += DeepCount(one);
                }
            }
            return sum;
        }


    }
}