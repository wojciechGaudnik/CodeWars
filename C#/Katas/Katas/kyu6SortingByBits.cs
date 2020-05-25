using System;
using System.Linq;

namespace Katas
{
    public class kyu6SortingByBits
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToString(8, 2));
            // Console.WriteLine(string.Join(", ", SortByBit(new[] {9, 4, 5, 3, 5, 7, 2, 56, 8, 2, 6, 8, 0})));
            Console.WriteLine(string.Join(", ", SortByBit(new[] {1,2,4,8,8,4})));

        }

        public static int[] SortByBit(int[] array)
        {
            return array
                .Select((number, index) =>
                    (index,
                        (Convert.ToString(number, 2).Count(numberOfOne => numberOfOne == '1')
                        , number)))
                .OrderBy(one => one.Item2.Item1)
                .ThenBy(e => e.Item2.Item2)
                .Select(e => e.Item2.Item2)
                .ToArray();
        }
    }
}