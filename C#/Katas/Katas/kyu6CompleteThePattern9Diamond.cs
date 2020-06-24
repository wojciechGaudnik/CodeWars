using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6CompleteThePattern9Diamond
    {
        public static string Pattern(int n)
        {
            var dict = new Dictionary<int, String>();
            var spaces = 0;
            var lineNumber = 0;
            while (n > 0)
            {
                var lineLeft = string.Join("", Enumerable.Range(1, n--).Select(n => n % 10).ToArray());
                var lineAll = lineLeft + string.Join("", lineLeft.Substring(0, lineLeft.Length - 1).Reverse());
                dict.Add(lineNumber--, new String(' ', spaces) + lineAll + new String(' ', spaces++) + '\n');
            }

            var bottomPlusMiddleLine = string.Join("", dict.Select(e => e.Value).ToArray());
            var up = string.Join("", dict.OrderBy(e => e.Key).Take(dict.Count - 1).Select(e => e.Value).ToArray());

            return up + bottomPlusMiddleLine.TrimEnd('\n');
        }
    }
}