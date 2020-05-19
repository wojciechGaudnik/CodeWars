using System;
using System.Text;

namespace Katas
{
    public class kyu6ConvertIntegerToWhitespaceFormat
    {
        public static string WhitespaceNumber(int n)
        {
            if(n == 0) return " \n";
            var answer = new StringBuilder();
            answer.Append(n < 0 ? "\t" : " ");
            n = Math.Abs(n);
            foreach (var one in Convert.ToString(n, 2))
            {
                answer.Append(one == '1' ? "\t" : " ");
            }
            return answer.Append("\n").ToString();
        }
    }
}