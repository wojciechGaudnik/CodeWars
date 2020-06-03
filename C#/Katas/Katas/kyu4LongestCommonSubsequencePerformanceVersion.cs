using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    public class kyu4LongestCommonSubsequencePerformanceVersion
    {
        public static string Lcs(string a, string b)
        {
            if (a == "" || b == "") return "";
            a = string.Join("", a.Where(b.Contains));
            b = string.Join("", b.Where(a.Contains));
            if (a == "" || b == "") return "";
            var answer = new StringBuilder();
            var array = new int[a.Length + 1, b.Length + 1];
            var y = 0;
            var x = 0;
            for (y = 0; y < a.Length; y++)
            {
                for (x = 0; x < b.Length; x++)
                {
                    if (a[y] == b[x]) array[y + 1, x + 1] = array[y, x] + 1;
                    else array[y + 1, x + 1] = Math.Max(array[y, x + 1], array[y + 1, x]);
                }
            }
            y = a.Length;
            x = b.Length;
            while (y > 0 && x > 0)
            {
                if (array[y, x - 1] == array[y - 1, x] )
                {
                    if (array[y - 1, x - 1] < array[y, x]) answer.Insert(0, a[y - 1]);
                    y--;
                    x--;
                }
                else
                {
                    if (array[y, x - 1] > array[y - 1, x]) x--;
                    else y--;
                }
            }
            return answer.ToString();
        }


        private static IEnumerable<IEnumerable<T>> GetVariation<T>(IEnumerable<T> word, int k)
        {
            var i = 0;
            foreach (var first in word)
            {
                if (k == 1) yield return new T[] {first};
                else
                    foreach (var second in GetVariation<T>(word.Skip(i + 1), k - 1))
                        yield return new[] {first}.Concat(second);
                ++i;
            }
        }
    }
}