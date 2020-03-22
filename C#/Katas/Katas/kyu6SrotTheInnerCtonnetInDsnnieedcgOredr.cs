using System.Linq;
using System.Text;

namespace Katas
{
    public class kyu6SrotTheInnerCtonnetInDsnnieedcgOredr
    {
        public static string SortTheInnerContent(string words)
        {
            var answer = new StringBuilder();
            var listWords = words.Split(" ");
            foreach (var one in listWords)
            {
                if (one.Length <= 3)
                {
                    answer.Append(one + " ");
                    continue;
                }

                var fist = one[0];
                var last = one[one.Length - 1];
                var descendingOrdered = one.Substring(1, one.Length - 2);
                descendingOrdered = string.Join("", descendingOrdered.OrderByDescending(c => c).ToList());
                answer.Append(fist + descendingOrdered + last + " ");
            }
            return answer.ToString().Trim();
        }


    }
}