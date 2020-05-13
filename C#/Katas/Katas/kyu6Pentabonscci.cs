using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Katas
{
    public class kyu6Pentabonscci
    {
        public static long CountOddPentaFib(long n)
        {
            long answer = 1;
            var queue = new Queue<BigInteger>(new BigInteger[]{0, 1, 1, 2, 4});

            for (long i = 4; i < n; i++)
            {
                var sum = queue.Aggregate((current, next) => current + next);
                if (sum % 2 == 1) answer++;
                queue.Enqueue(sum);
                queue.Dequeue();
            }
            return answer;
        }
    }
}