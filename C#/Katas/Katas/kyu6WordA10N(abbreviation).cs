using System.Text.RegularExpressions;

namespace Katas
{
    public class kyu6WordA10N_abbreviation_
    {
        public static string Abbreviate(string input)
        {
            var regex = new Regex("\\w*");
            var answer = input;

            foreach (Match one in regex.Matches(input))
            {
                if (one.Length > 3)
                {
                    answer = answer.Replace(one.ToString(), one.ToString()[0] + (one.Length - 2).ToString() + one.ToString()[one.Length - 1]);

                }
            }
            return answer;
        }
    }
}