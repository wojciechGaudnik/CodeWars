namespace Katas
{
    using System;
    public class SumFractions
    {
        public static string SumFracts(int[,] l)
        {
            if(l.Length == 0) return null;
            int a = l[0,0];
            int b = l[0,1];

            for(int i = 1; i < (l.Length / 2); i++)
            {
                int c = l[i, 0];
                int d = l[i, 1];
                int lcm = LCM(b, d);
                a = (lcm / b) * a + (lcm / d) * c;
                b = lcm;
                Console.WriteLine(a + " <---" + lcm);
            }
            return (a % b == 0)? $"{a / b}": $"[{a / GCD(a, b)}, {b / GCD(a, b)}]";
        }

        static int GCD(int a, int b)
        {
            if (a == 0)
                return b;
            return GCD(b % a, a);
        }

        static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }
    }
}