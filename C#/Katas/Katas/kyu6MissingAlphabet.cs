using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    public class kyu6MissingAlphabet
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(InsertMissingLetters("hello"));
            Console.WriteLine("hIJKMNPQRSTUVWXYZeFGIJKMNPQRSTUVWXYZlMNPQRSTUVWXYZloPQRSTUVWXYZ");
        }

        public static string InsertMissingLetters(string str) {
            var alpha = string.Join("",
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
                    .Select(c => (str.Contains(char.ToLower(c))) ? ' ' : c)
                    .ToArray());
            var all = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var used = new HashSet<char>();
            var answer = new StringBuilder();
            foreach (var one in str)
            {
                if (used.Contains(one))
                {
                    answer.Append(one);
                    continue;
                }
                used.Add(one);
                answer.Append(one);
                answer.Append(alpha.Substring(all.IndexOf(char.ToUpper(one)) + 1).Replace(" ", ""));
            }
            return answer.ToString();
        }
    }
}