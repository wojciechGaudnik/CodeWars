using System;
using System.Linq;
using System.Text;

namespace Katas
{
    public class StripCommentsKata
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            char[] separatorsChar = commentSymbols.Select(char.Parse).ToArray();
            string[] lines = text.Split("\n");
            StringBuilder answer = new StringBuilder();
            foreach (var s in lines)
            {
                answer.AppendLine(s.Split(separatorsChar)[0].TrimEnd());
            }
            return answer.ToString().Substring(0, answer.Length - 1);
        }
    }
}