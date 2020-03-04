using System;
using System.Linq;

namespace Katas
{
    public class kyu6TribonacciSequence
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            Console.WriteLine(string.Join(", ", signature) + " : " + n);
            var answer = signature.Select(e => e).ToList();
            for (var i = 0; i < n - 3; i++)
            {
                answer.Add(answer[i] + answer[i + 1] + answer[i + 2]);
            }
            return answer.Take(n).ToArray();
        }
    }
}