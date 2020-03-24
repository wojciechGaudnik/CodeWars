using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6StringAverage
    {
        public static void Main(string[] args)
        {

        }

        public static string AverageString(string str)
        {
            var dictionary = new Dictionary<string, int>
            {
                {"zero", 0},
                {"one", 1},
                {"two", 2},
                {"three", 3},
                {"four", 4},
                {"five", 5},
                {"six", 6},
                {"seven", 7},
                {"eight", 8},
                {"nine", 9},
            };
            if(!str.Split(" ").All(one => dictionary.ContainsKey(one))) return "n/a";
            return dictionary.First(k => k.Value == str
                .Split(" ")
                .Select(one => dictionary[one])
                .Sum() / str.Split(" ").Length).Key;
        }
    }
}