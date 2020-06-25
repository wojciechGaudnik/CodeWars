using System.Linq;

namespace Katas
{
    public class kyu5WeightForWeight
    {
        public static string orderWeight(string strng) {
            return string.Join(" ",
                strng
                    .Split(" ")
                    .OrderBy(SumDigit)
                    .ThenBy(s => s)
                    .ToArray() );
        }
        private static int SumDigit(string number) => number.Select(c => int.Parse("" + c)).Sum();
    }
}