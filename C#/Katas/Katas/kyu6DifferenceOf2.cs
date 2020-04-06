using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6DifferenceOf2
    {
        public static void Main(string[] args)
        {
            var test = new[] {1, 23, 3, 4, 7};
            Console.WriteLine(string.Join(", ", TwosDifference(test)));
        }

        public static (int, int)[] TwosDifference(int[] array)
        {
            Array.Sort(array);
            var answer = new HashSet<(int, int)>();
            for (var i = 0; i < array.Length - 1; i++)
            {
                if (array[i] + 2 == array[i + 1])
                {
                    answer.Add((array[i], array[i + 1]));
                }
                if (i + 2 < array.Length && array[i] + 2 == array[i + 2])
                {
                    answer.Add((array[i], array[i + 2]));
                }
            }
            return answer.ToArray();
        }
    }
}