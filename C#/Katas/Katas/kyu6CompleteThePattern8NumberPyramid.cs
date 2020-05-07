using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    public class kyu6CompleteThePattern8NumberPyramid
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Pattern(1));
            Console.WriteLine(Pattern(5));
            Console.WriteLine(Pattern(15));
            Console.WriteLine("12345678901234543210987654321".Equals("12345678901234543210987654321"));
        }

        public static string Pattern(int n)
        {
            var answerArray = new LinkedList<string>();
            if(n <= 0) return "";
            var line = new StringBuilder();
            var numbers = new [] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            for (int i = 0, nBuff = 0; nBuff < n; i++, nBuff++)
            {
                if (i >= 10) i = 0;
                line.Append(numbers[i]);
            }
            line.Append(string
                .Join("", line
                .ToString()
                .Substring(0, line.Length - 1)
                .Reverse()));
            var spaces = 0;
            while (line.Length > 1)
            {
                answerArray.AddFirst(new String(' ', spaces) + line + new String(' ', spaces++) + '\n');
                line = line.Remove(line.Length / 2, 2);
            }
            answerArray.AddFirst(new String(' ', spaces) + line + new String(' ', spaces++) + '\n');
            return string.Join("", answerArray).TrimEnd();
        }
    }
}