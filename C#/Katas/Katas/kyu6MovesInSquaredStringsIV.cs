using System;
using System.Linq;
using System.Text;

namespace Katas
{
    public class kyu6MovesInSquaredStringsIV
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Rot90Counter("EcGcXJ\naaygcA\nNgIshN\nyOrCZE\neBEqpm\nNkxCgw"));
            Console.WriteLine("JANEmw\nXchZpg\ncgsCqC\nGyIrEx\ncagOBk\nEaNyeN");
        }

        public static string Rot90Counter(string strng) {
            var arrayStrings = strng.Split("\n").Select(s => s.ToCharArray()).ToArray();
            var arrayStringsAnswer = strng.Split("\n").Select(s => s.ToCharArray()).ToArray();
            for (var x = arrayStrings[0].Length - 1; x >= 0 ; x--)
            {
                for (var y = 0; y < arrayStrings.Length; y++)
                {
                    arrayStringsAnswer[arrayStrings[0].Length - 1 - x][y] = arrayStrings[y][x];
                }
            }
            return string.Join("\n", arrayStringsAnswer.Select(line => string.Join("", line)).ToArray());
        }
        public static string Diag2Sym(string strng) {
            var arrayStrings = strng.Split("\n").Select(s => s.ToCharArray()).ToArray();
            var arrayStringsAnswer = strng.Split("\n").Select(s => s.ToCharArray()).ToArray();
            for (var x = arrayStrings[0].Length - 1; x >= 0 ; x--)
            {
                for (var y = arrayStrings.Length - 1; y >= 0 ; y--)
                {
                    arrayStringsAnswer[arrayStrings[0].Length - 1 - x][arrayStrings.Length - 1 - y] = arrayStrings[y][x];
                }
            }
            return string.Join("\n", arrayStringsAnswer.Select(line => string.Join("", line)).ToArray());
        }

        public static string SelfieDiag2Counterclock(string strng) {
            var strArr = strng.Split("\n");
            var strDiag = Diag2Sym(strng).Split("\n");
            var strRot = Rot90Counter(strng).Split("\n");
            var answer = new StringBuilder();
            for (var i = 0; i < strArr.Length; i++)
            {
                answer.Append(strArr[i] + "|" + strDiag[i] + "|" + strRot[i] + "\n");
            }
            return answer.ToString().TrimEnd();

        }

        public static string Oper(Func<string, string> func, string s)
        {
            return func(s);
        }
        
    }


}