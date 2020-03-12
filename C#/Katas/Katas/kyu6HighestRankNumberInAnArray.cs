using System.Linq;

namespace Katas
{
    public class kyu6HighestRankNumberInAnArray
    {
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