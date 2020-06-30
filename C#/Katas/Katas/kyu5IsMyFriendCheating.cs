using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Katas
{
    public class kyu5IsMyFriendCheating
    {
        public static List<long[]> removNb(long n)
        {
            Console.WriteLine(n);
            var dict = new SortedDictionary<long, long>();
            BigInteger sum = 0;
            BigInteger bN = new BigInteger(n);
            sum = (bN * (bN + 1)) / 2;
            Console.WriteLine(sum);
            for (long x = 2; x <= n; x++)
            {
                var div = (sum - x) / (x + 1);
                if ((sum - x) % (x + 1) == 0 && div <= n && div > 0)
                {
                    Console.WriteLine(x + " " + div);
                    dict.Add(x , (long)div);
                }
            }
            return dict.Select(e => new [] {e.Key, e.Value}).ToList();
        }
    }
}