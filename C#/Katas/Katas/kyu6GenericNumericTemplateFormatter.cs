using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas
{
    public class kyu6GenericNumericTemplateFormatter
    {
        public static string NumericFormatter(string template, string number = null)
        {
            var templateBuilder = new StringBuilder(template);
            number =
                string.Concat(number == null ? Enumerable.Repeat("1234567890", (template.Length / 10) + 3)
                    : Enumerable.Repeat(number, 30));
            var pattern = new Regex("[a-zA-Z]");
            number = pattern.Replace(number, "");
            var numberIndex = 0;
            for (var i = 0; i< template.Length; i++)
            {
                if (!char.IsLetter(template[i])) continue;
                templateBuilder.Remove(i, 1);
                templateBuilder.Insert(i, number[numberIndex++]);
            }
            return templateBuilder.ToString();
        }
    }
}