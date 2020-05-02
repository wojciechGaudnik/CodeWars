using System.Linq;

namespace Katas
{
    public class kyu6ReachMeAndSumMyDigits
    {
        public static long SumDigNthTerm(long init, long[] patternl, int n)
        {
            var j = 0;
            for (var i = 0; i < n - 1; i++)
            {
                init += patternl[j++];
                if(j == patternl.Length)
                {
                    j = 0;
                }
            }
            return init.ToString().Select(c => int.Parse(c.ToString())).Sum();
        }
    }
}