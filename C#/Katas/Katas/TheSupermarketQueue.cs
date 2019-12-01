using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class TheSupermarketQueue
    {
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