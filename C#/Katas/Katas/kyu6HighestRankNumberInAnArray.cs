using System;
using System.Linq;

namespace Katas
{
    public class kyu6HighestRankNumberInAnArray
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine(HighestRank(new int[] {12, 10, 8, 8, 3, 3, 3, 3, 2, 4, 10, 12, 10}));
            Console.WriteLine(HighestRank(new int[] {1,1, 2, 2, 3, 3, 4, 5}));
            Console.WriteLine(HighestRank(new int[] {7, 4, 6, 9, 4, 9, 11, 10, 11, 3, 5, 10, 5, 10, 5}));

        }

        public static int HighestRank(int[] arr)
        {
            var test = arr
                .GroupBy(e => e)
                .Select(g => new {Type = g.Key, Count = g.Count()})
                .OrderBy(e => e.Count)
                .Last()
                .Type;
            return arr
                .GroupBy(e => e)
                .Select(g => new {Type = g.Key, Count = g.Count()})
                .OrderBy(e => e.Count)
                .ThenBy(e => e.Type)
                .Last()
                .Type;
        }
    }
}