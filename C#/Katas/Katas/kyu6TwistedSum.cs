using System;
using System.Linq;

namespace Katas
{
    public class kyu6TwistedSum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(1 + 2+3+4+5+6+7+8+9);
            Console.WriteLine(Solution(3));
            Console.WriteLine(Solution(9) + "<--- 45");
            Console.WriteLine(Solution(10) + "<--- 46");
            Console.WriteLine(Solution(11) + "<--- 48");
            var n = 10;
            var sum = 0;

            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }

            // Console.WriteLine(sum);
        }

        public static long Solution(long n)
        {
            var sum = Enumerable.Range(0, (n < 10)?(int) n + 1:10).Sum();
            for (var i = 10; i <= n; i++)
            {
                var next = i;
                while (next != 0)
                {
                    sum += next % 10;
                    next /= 10;
                }
            }
            return sum;
        }
    }
}