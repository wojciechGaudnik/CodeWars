using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas
{
    public class kyu6TitleCase
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine(TitleCase("a clash of KINGS"));
            Console.WriteLine(TitleCase("THE WIND IN THE WILLOWS", "in The"));
        }

        public static string TitleCase(string title, string minorWords="")
        {
            if(title == null) return "";
            if(minorWords == null) minorWords = "";
            var myTI = new CultureInfo("en-US",false).TextInfo;
            title = myTI.ToLower(title);
            title = myTI.ToTitleCase(title);
            var answer = new StringBuilder();
            foreach (var word in title.Split(" "))
            {
                var isChanged = false;
                foreach (var minorWord in minorWords.Split(" ").Select(w => w.ToLower()))
                {
                    if (!word.ToLower().Equals(minorWord.ToLower())) continue;
                    answer.Append(minorWord.ToLower() + " ");
                    isChanged = true;
                    break;
                }
                if (!isChanged)
                {
                    answer.Append(word + " ");
                }
            }
            answer[0] = char.ToUpper(answer[0]);
            return answer.ToString().TrimEnd();
        }
    }
}