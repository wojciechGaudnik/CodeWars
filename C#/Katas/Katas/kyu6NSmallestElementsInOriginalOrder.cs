using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6NSmallestElementsInOriginalOrder
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", FirstNSmallest(new []{1,2,3,-4,0},3)));
            Console.WriteLine(string.Join(", ", FirstNSmallest(new[] { 1, 2, 3, 1, 2 }, 3)));
            Console.WriteLine(string.Join(", ", FirstNSmallest(new[] { 2, 1, 2, 3, 4, 2 }, 2)));
        }

        public static int[] FirstNSmallest(int[] arr, int n)
        {
            var list = new List<int>(arr);
            list.Reverse();
            while (list.Count > n) list.Remove(list.Max());
            list.Reverse();
            return list.ToArray();
        }
    }
}