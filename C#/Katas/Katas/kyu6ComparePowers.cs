using System;

namespace Katas
{
    public class kyu6ComparePowers
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine(ComparePowers(new []{2,10},new []{2,15}));
            // Console.WriteLine(ComparePowers(new []{3,9},new []{5,6}));
            // Console.WriteLine(ComparePowers(new []{2,10},new []{3,10}));
            // Console.WriteLine(ComparePowers(new []{802,113},new []{802,143}));
            Console.WriteLine(ComparePowers(new []{710,111},new []{233,137}));
            // Console.WriteLine(determineLCM(2,3));
            // Console.WriteLine(LCM(2,3));
        }

        public static int ComparePowers(int[] a, int[] b)
        {
            Console.WriteLine(string.Join(", ", a) + "<--- a");
            Console.WriteLine(string.Join(", ", b) + "<--- b");
            if (a[0] == b[0]) return (a[1] == b[1]) ? 0 : (a[1] < b[1]) ? 1 : -1;
            var aPow = Math.Pow(a[0], a[1]);
            var bPow = Math.Pow(b[0], b[1]);
            return (aPow == bPow) ? 0 : (aPow < bPow) ? 1 : -1;
        }

        // public static int ComparePowers(int[] a, int[] b)
        // {
        //     var lcm = LCM(a[0], b[0]);
        //     var aEx = (lcm / a[0] - 1) * a[1];
        //     var bEx = lcm / b[0] - 1 + b[1];
        //     return (aEx == bEx) ? 0: (aEx < bEx) ? 1 : -1;
        // }

        static int GCD(int a, int b)
        {
            return a == 0 ? b : GCD(b % a, a);
        }

        static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }

        public static int determineLCM(int a, int b)
        {
            int num1, num2;
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            for (int i = 1; i < num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                {
                    return i * num1;
                }
            }
            return num1 * num2;
        }
    }
}