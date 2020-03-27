using System.Collections.Generic;
using System.Text;

namespace Katas
{
    public class kyu6NumericalsOfAString
    {
        public static string Numericals(string s)
        {
            var dictionary = new Dictionary<char, int>();
            var answer = new StringBuilder();
            foreach (var c in s)
            {
                if (dictionary.ContainsKey(c))
                {
                    dictionary[c]++;
                    answer.Append(dictionary[c]);
                    continue;
                }
                dictionary.Add(c, 1);
                answer.Append(dictionary[c]);
            }
            return answer.ToString();
        }
    }
}