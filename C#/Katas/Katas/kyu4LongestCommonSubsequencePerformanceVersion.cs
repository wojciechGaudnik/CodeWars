using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    public class kyu4LongestCommonSubsequencePerformanceVersion
    {
        // public static void Main(string[] args)
        // {
        //     var a = "abcdefghijklmnopq";
        //     var b = "apcdefghijklmnobq";
        //     // a = "abcdef";
        //     // b = "acf";
        //
        //
        //
        //
        //
        //
        //     Console.WriteLine(Lcs(a, b) + " <---acdefghijklmnoq");
        //
        //
        //     var list = new List<string> { "a", "b", "c", "d", "e" };
        //     var result = GetVariation(list, 3);
        //     foreach (var perm in result)
        //     {
        //         foreach (var c in perm)
        //         {
        //             Console.Write(c + " ");
        //         }
        //         Console.WriteLine();
        //     }
        // }



        public static string Lcs(string a, string b)
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