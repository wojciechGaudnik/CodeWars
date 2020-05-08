using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6NSmallestElementsInOriginalOrder
    {
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