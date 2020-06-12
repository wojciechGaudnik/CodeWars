using System;

namespace Katas
{
    public class kyu6StrongestEvenNumerInAnInterval
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine(strongestEven(1,2));
            // Console.WriteLine(strongestEven(5,10));
            // Console.WriteLine(strongestEven(689930869,2079841036));
            Console.WriteLine(strongestEven(3,310));
        }

        public static int strongestEven(int n, int m)
        {
            if(n == 1 && m == 2) return 2;
            long number = 1;
            long numberBuff = number;
            while (true)
            {
                numberBuff = number;
                while (numberBuff <= m)
                {
                    if (numberBuff >= n && numberBuff * 2 > m) return (int)numberBuff;
                    numberBuff *= 2;
                }
                number++;
            }
        }


        public static int strongestEven2(int n, int m)
        {
            var even = 2;
            var evenBuff = 0;
            var odd = 1;
            var oddBuff = 1;
            while (true)
            {
                evenBuff = even;
                while (evenBuff <= m)
                {
                    if (evenBuff >= n) return evenBuff;
                    evenBuff *= 2;
                }

                oddBuff = odd;
                while (oddBuff <= m)
                {
                    if (oddBuff >= n) return oddBuff;
                    oddBuff *= 2;
                }

                even += 2;
                odd += 2;
            }
        }

        public static int strongestEven1(int n, int m)
        {
            Console.WriteLine(n + " " + m);
            if (m % 2 == 1) m--;
            if (m / 2 > n) n = m / 2;
            if (n % 2 == 1) n++;
            var max = int.MinValue;
            var strongest = 0;
            var answer = 0;
            for (var i = m; i >= n; i -= 2)
            {
                var j = i;

                // var bit = Convert.ToString(j, 2);
                // var strongest = bit.Length - bit.LastIndexOf('1');
                Console.WriteLine("---------");
                while (j % 2 == 0)
                {
                    Console.WriteLine(Convert.ToString(j, 2) + " " + strongest);
                    j /= 2;
                    strongest++;

                }

                if (strongest > max)
                {
                    max = strongest;
                    answer = i;
                }
            }
            return answer;
        }


    }
}