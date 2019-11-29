using System;
using System.Linq;

namespace Katas
{
    public class GarbleSortClass
    {
        public static int[] GarbleSort(int[] values)
        {
            int[] order = {7, 9, 6, 4, 1, 3, 5, 8, 2};
            int[] ordered = new int[0];
            foreach (var i in order)
            {
                ordered = ordered.Concat(Array.FindAll(values, j => j == i)).ToArray();
            }
            return ordered;
        }
    }
}