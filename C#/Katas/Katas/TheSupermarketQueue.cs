using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class TheSupermarketQueue
    {
        static void Main(string[] args)
        {
            Console.WriteLine(QueueTime(new int[]{5,3,4}, 1));
            Console.WriteLine(QueueTime(new int[]{10,2,3,3}, 2));
            Console.WriteLine(QueueTime(new int[]{2,3,10}, 2));
        }

        public static long QueueTime(int[] customers, int n)
        {
            List<int> tills = new List<int>(n);
            while (n-- > 0)
            {
                tills.Add(0);
            }
            foreach (int q in customers)
            {
                int minIndex = tills.IndexOf(tills.Min());
                tills[minIndex] += q;
            }
            return tills.Max();
        }
    }
}