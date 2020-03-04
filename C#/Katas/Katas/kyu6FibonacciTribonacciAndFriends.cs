using System.Linq;

namespace Katas
{
    public class kyu6FibonacciTribonacciAndFriends
    {
        public double[] xbonacci(double[] signature, int n)
        {
            var answer = signature.Select(e => e).ToList();
            var X = signature.Length;
            for (var i = X; i < n; i++)
            {
                double sum = 0;
                for (var j = 1; j <= X; j++)
                {
                    sum += answer[i - j];
                }
                answer.Add(sum);
            }
            return answer.Take(n).Select(e => e).ToArray();
        }


    }
}