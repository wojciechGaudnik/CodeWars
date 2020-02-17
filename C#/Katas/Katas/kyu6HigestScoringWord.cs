using System;
using System.Linq;

namespace Katas
{
    public class kyu6HigestScoringWord
    {
        public static string High(string s)
        {
            var max = 0;
            var word = "";
            foreach (var one in s.Split(" "))
            {
                Console.WriteLine(one);
                var tempMax = one.Trim().Select(c => ((int)c -'a') + 1 ).Sum();
                if (tempMax > max)
                {
                    max = tempMax;
                    word = one;
                }
            }
            return word;
        }
    }
}