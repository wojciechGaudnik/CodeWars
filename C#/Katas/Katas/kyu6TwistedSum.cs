using System.Linq;

namespace Katas
{
    public class kyu6TwistedSum
    {
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