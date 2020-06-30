using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu5JosephusSurvivor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(JosSurvivor(7,3));

        }

        public static int JosSurvivor(int n, int k)
        {
            if (n == 1)
                return 1;
            return (JosSurvivor(n - 1, k) + k - 1) % n + 1;
        }
    }
}