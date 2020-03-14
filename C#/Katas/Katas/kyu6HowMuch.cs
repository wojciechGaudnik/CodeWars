using System;
using System.Text;

namespace Katas
{
    public class kyu6HowMuch
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(howmuch(1, 100));
        }

        public static string howmuch(int m, int n) {
            var answer = new StringBuilder();
            answer.Append("[");

            if (n < m) (m , n) = (n , m);
            for (var i = m; i <= n; i++)
            {
                if ((i - 2) % 7 == 0 && (i - 1) % 9 == 0)
                {
                    answer
                        .Append("[M: " + i)
                        .Append(" B: " + (i - 2) / 7)
                        .Append(" C: " + (i - 1) / 9 + "]");
                }
            }
            answer.Append("]");
            return answer.ToString();
        }
    }
}