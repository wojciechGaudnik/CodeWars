using System.Text;

namespace Katas
{
    public class kyu6WelrdStringCase
    {
        public static string ToWeirdCase(string s)
        {
            var answer = new StringBuilder();
            foreach (var oneWord in s.Split(" "))
            {
                var answerOneWord = new StringBuilder();
                for (var i = 0; i < oneWord.Length; i++)
                {
                    answerOneWord.Append((i % 2 == 0)?char.ToUpper(oneWord[i]):char.ToLower(oneWord[i]));
                }
                answer.Append(answerOneWord + " ");
            }
            return answer.ToString().Substring(0, s.Length);
        }

    }
}