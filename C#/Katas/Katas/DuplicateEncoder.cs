using System;
using System.Linq;
using System.Text;

namespace Katas
{
    public class DuplicateEncoder
    {
        public static string DuplicateEncode(string word)
        {
            // return new string(word.ToLower().Select(ch => word.ToLower().Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray());

            StringBuilder answer = new StringBuilder();
            foreach (char i in word.ToLower())
            {
                Console.WriteLine(i);
                if (word.ToLower().ToArray().Count(x => x == i) == 1)
                {
                    answer.Append("(");
                }
                else
                {
                    answer.Append(")");
                }
            }
            return answer.ToString();
        }
    }
}