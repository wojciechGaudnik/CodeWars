using System;
using System.Text.RegularExpressions;

namespace Katas
{
    public class BerserkRater_CGVs_Clang
    {
        static void Main(string[] args)
        {

        }

        public static string BerserkRater(string[] synopsis)
        {
            int score = 0;

            foreach (var store in synopsis)
            {
                Console.WriteLine(store);
                Regex regex = new Regex("[^a-zA-Z]cg[^a-zA-Z]", RegexOptions.IgnoreCase);
                int cg = regex.Matches($" {store} ").Count;
                regex = new Regex("[^a-zA-Z]clang([^a-zA-Z]|ed|s|ing|ness)", RegexOptions.IgnoreCase);
                int clang = regex.Matches($" {store} ").Count;
                if (cg > 0 && clang > 0) score += 5;
                else if (cg > 0) score -= 2;
                else if (clang > 0) score += 5;
                else score--;
                Console.WriteLine(store);
            }

            Console.WriteLine(score);
            if(score < 0 ) return "worstest episode ever";
            if (score >= 0 && score <= 10) return score.ToString();
            return "bestest episode ever";
        }

    }
}