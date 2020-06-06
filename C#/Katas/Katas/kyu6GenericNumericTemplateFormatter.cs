using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas
{
    public class kyu6GenericNumericTemplateFormatter
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine(NumericFormatter("xxx xxxxx xx", "54652a532b8z9A"));
            // Console.WriteLine(NumericFormatter("o6q*x+3UAiAXPkF4LzH", "30193786375"));
            Console.WriteLine(NumericFormatter("F+oB3 IWM5V4Qgk ", "864295"));
            Console.WriteLine("8+643 295584642 ");
        }

        public static string NumericFormatter(string template, string number = null)
        {
            Console.WriteLine("--->" + template + "<--t--n-->" + number + "<---");
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