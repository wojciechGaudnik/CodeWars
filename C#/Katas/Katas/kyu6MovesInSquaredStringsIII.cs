using System;
using System.Linq;
using System.Text;

namespace Katas
{
    public class kyu6MovesInSquaredStringsIII
    {
        public static string Rot90Clock(string strng) {
            var answer = new StringBuilder();
            var strngArr = strng.Split('\n').ToArray();
            Array.Reverse(strngArr);
            for (var x = 0; x < strngArr[0].Length; x++)
            {
                for (var y = 0; y < strngArr.Length; y++)
                {
                    answer.Append(strngArr[y][x]);
                }
                answer.Append('\n');
            }
            return answer.ToString().Trim();
        }

        public static string Diag1Sym(string strng)
        {
            var answer = new StringBuilder();
            var strngArr = strng.Split('\n').ToArray();
            for (var x = 0; x < strngArr[0].Length; x++)
            {
                for (var y = 0; y < strngArr.Length; y++)
                {
                    answer.Append(strngArr[y][x]);
                }
                answer.Append('\n');
            }
            return answer.ToString().Trim();
        }

        public static string SelfieAndDiag1(string strng)
        {
            var answer = new StringBuilder();
            var strngArr = strng.Split('\n').ToArray();
            var diagArr = Diag1Sym(strng).Split('\n').ToArray();
            for (var i = 0; i < strngArr.Length; i++)
            {
                answer.Append(strngArr[i]).Append("|").Append(diagArr[i]).Append("\n");
            }
            return answer.ToString().Trim();
        }

        public static string Oper(Func<string, string> func, string s)
        {
            return func(s);
        }
    }
}