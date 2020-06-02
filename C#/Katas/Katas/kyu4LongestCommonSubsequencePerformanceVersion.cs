using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    public class kyu4LongestCommonSubsequencePerformanceVersion
    {
        public static void Main(string[] args)
        {
            var a = "abcdefghijklmnopq";
            var b = "apcdefghijklmnobq";
            // a = "abcdaf";
            // b = "acbcf";
            // a = "132535365";
            // b = "123456789";
            a = "anothertest";
            b = "notatest";


            Console.WriteLine(Lcs(b, a));



        }

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

        private static void printArray(string a, string b, int[,] array)
        {
            Console.WriteLine("      " + string.Join("", b.Select(c => c + " ,").ToArray()));
            for (var i = 0; i <= a.Length; i++)
            {
                var line = "   ";
                if (i > 0 && i <= a.Length)
                {
                    line = a[i - 1] + "| ";
                }

                for (var j = 0; j <= b.Length; j++)
                {
                    line += array[i, j] + " ,";
                }

                Console.WriteLine(line);
            }
        }


        public static string Lcs2(string a, string b)
        {
            if (a == "" || b == "") return "";
            var commonA = string.Join("", a.Where(b.Contains));
            var commonB = string.Join("", b.Where(a.Contains));
            if (commonA == "" || commonB == "") return "";
            (commonA, commonB) = (commonA.Length > commonB.Length) ? (commonA, commonB) : (commonB, commonA);
            for (var k = commonB.Length; k > 0; k--)
            {

            }
            Console.WriteLine(a);
            Console.WriteLine(commonA);
            Console.WriteLine(b);
            Console.WriteLine(commonB);


            return "";
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


        public static string Lcs1(string a, string b)
        {
            if (a == "" || b == "") return "";

            var first = LcsTool(a, b);
            var second = LcsTool(b, a);
            return  first.Length > second.Length ? first : second;
        }

        private static string LcsTool(string a, string b)
        {
            var answerFirst = new StringBuilder();
            var jBuff = 0;
            foreach (var t in a)
            {
                for (var j = jBuff; j < b.Length; j++)
                {
                    if (t != b[j]) continue;
                    answerFirst.Append(t);
                    jBuff = j + 1;
                    break;
                }
            }

            Console.WriteLine(a[0]);
            return answerFirst.ToString();
        }
    }
}