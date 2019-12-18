using System.Text.RegularExpressions;

namespace Katas
{

    public class SimpleFun180RepeatAdjacent
    {

        public int RepeatAdjacent(string s)
        {
            // var r=Regex.Matches(s,"((.)\\2+(?!\\2)){2,}");
            MatchCollection matchCollection = Regex.Matches(s, "(.)\\1+|.");
            var count = 0;
            var partCount = 0;
            foreach (Match g in matchCollection)
            {
                if (g.Length > 1)partCount++;
                if (g.Length == 1)
                {
                    if (partCount > 1) count++;
                    partCount = 0;
                }
            }
            return (partCount > 1)? count + 1: count;
        }
    }
}