using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6PrizeDraw
    {
        public static string NthRank(string st, int[] we, int n)
        {
            if (string.IsNullOrEmpty(st)) return "No participants";
            if (n > st.Split(",").Length) return "Not enough participants";
            var dictionary = new Dictionary<string, int>();
            var spitedString = st.Split(",");
            for (var i = 0; i < spitedString.Length; i++)
            {
                var sum = spitedString[i].Sum(one => char.ToLower(one) - 96);
                dictionary.Add(spitedString[i], (sum + spitedString[i].Length) * we[i]);
            }
            return dictionary
                .OrderByDescending(k => k.Value)
                .ThenBy(v => v.Key)
                .ToArray()[n - 1].Key;
        }
    }
}