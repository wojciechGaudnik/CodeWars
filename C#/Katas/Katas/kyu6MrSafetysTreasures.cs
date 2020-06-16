using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    public class kyu6MrSafetysTreasures
    {
        public static string Unlock(string str)
        {
            var dict = new Dictionary<string, int>()
            {
                {"abc", 2},
                {"def", 3},
                {"ghi", 4},
                {"jkl", 5},
                {"mno", 6},
                {"pqrs", 7},
                {"tuv", 8},
                {"wxyz", 9},
            };
            var answer = new StringBuilder();
            foreach (var one in str)
            {
                answer.Append(
                    dict.Where((d) => d.Key.Contains(char.ToLower(one)))
                        .Select(e => e.Value)
                        .ElementAt(0));
            }

            return answer.ToString();
        }
    }
}