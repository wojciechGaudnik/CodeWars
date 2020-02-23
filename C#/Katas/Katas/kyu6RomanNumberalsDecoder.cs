using System;
using System.Collections.Generic;

namespace Katas
{
    public class kyu6RomanNumberalsDecoder
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Solution("XXI"));


        }

        public static int Solution(string roman)
        {
            var dic = new Dictionary<String, int>()
            {
                {"M", 1000},
                {"CM", 900},
                {"D", 500},
                {"CD", 400},
                {"C", 100},
                {"XC", 90},
                {"L", 50},
                {"XL", 40},
                {"X", 10},
                {"IX", 9},
                {"V", 5},
                {"IV", 4},
                {"I", 1},
            };
            var answer = 0;
            var i = 0;
            foreach (var one in dic)
            {
                while (i + one.Key.Length <= roman.Length && roman.Substring(i, one.Key.Length).Equals(one.Key))
                {
                    answer += one.Value;
                    i += one.Key.Length;
                }
            }
            return answer;
        }
    }
}