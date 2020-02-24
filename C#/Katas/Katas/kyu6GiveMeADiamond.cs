using System;
using System.Linq;
using System.Text;

namespace Katas
{
    public class kyu6GiveMeADiamond
    {
        public static string print(int n)
        {
            if(n % 2 == 0 || n <= 0) return null;
            var answer = new StringBuilder();
            for (var i = 1; i < n; i += 2)
            {
                answer.Append(Centered(String.Concat(Enumerable.Repeat("*", i)), n));
                answer.Append("\n");
            }
            for (var i = n; i > 0; i -= 2)
            {
                answer.Append(Centered(String.Concat(Enumerable.Repeat("*", i)), n));
                answer.Append("\n");
            }
            return answer.ToString();
        }

        private static string Centered(string diamonds, int size)
        {
            var free = size - diamonds.Length;
            var left = free/2 + diamonds.Length;
            return diamonds.PadLeft(left);
        }
    }
}