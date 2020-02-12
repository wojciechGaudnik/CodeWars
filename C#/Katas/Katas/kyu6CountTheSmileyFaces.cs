using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class kyu6CountTheSmileyFaces
    {
        public static int CountSmileys(string[] smileys)
        {
            var pattern = "(:|;)(-|~)*(\\)|D)";
            var regex = new Regex(pattern);
            return smileys.Count(s => regex.IsMatch(s));
        }
    }
}