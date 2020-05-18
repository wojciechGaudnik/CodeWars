using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas
{
    public class kyu6ConvertIntegerToWhitespaceFormat
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(WhitespaceNumber(100));
        }

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