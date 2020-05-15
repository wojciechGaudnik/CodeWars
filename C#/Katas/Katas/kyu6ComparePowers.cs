using System;

namespace Katas
{
    public class kyu6ComparePowers
    {
        public static int ComparePowers(int[] a, int[] b)
        {
            Console.WriteLine(string.Join(", ", a) + "<--- a");
            Console.WriteLine(string.Join(", ", b) + "<--- b");
            if (a[0] == b[0]) return (a[1] == b[1]) ? 0 : (a[1] < b[1]) ? 1 : -1;
            var aPow = Math.Pow(a[0], a[1]);
            var bPow = Math.Pow(b[0], b[1]);
            return (aPow == bPow) ? 0 : (aPow < bPow) ? 1 : -1;
        }
    }
}