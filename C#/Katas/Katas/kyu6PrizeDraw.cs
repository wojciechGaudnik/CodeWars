using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6PrizeDraw
    {
        public static void Main(string[] args)
        {
            var st = "A,Elijah,Chloe,Elizabeth,Matthew,Natalie,Jayden";
            var we = new int[] {1, 3, 5, 5, 3, 6};
            // Console.WriteLine(NthRank(st, we, 2));

            st = "Sophia,Robert,Abigail,Grace,Lagon";
            we = new int[] {2,6,5,5,3,4};
            Console.WriteLine(NthRank(st, we, 5));
        }

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