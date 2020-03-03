using System;

namespace Katas
{
    public class kyu6TwoJoggers
    {
        public static Tuple<int, int> NbrOfLaps(int x, int y)
        {
            int lcm = LCM(x, y);
            return new Tuple<int, int>(lcm / x, lcm / y);
        }

        public static int GCD(int a, int b)
        {
            return a == 0 ? b : GCD(b % a, a);
        }

        public static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }
    }
}