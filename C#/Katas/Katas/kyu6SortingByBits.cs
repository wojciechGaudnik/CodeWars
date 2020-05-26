using System;
using System.Linq;

namespace Katas
{
    public class kyu6SortingByBits
    {
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