using System.Text;

namespace Katas
{
    public class kyu5Rot13
    {
        public static string Rot13(string message)
        {
            var alphabetUper = "NOPQRSTUVWXYZABCDEFGHIJKLM";
            var alphabetLower = alphabetUper.ToLower();
            var answer = new StringBuilder();
            foreach (var c in message)
            {
                if (char.IsLower(c))
                {
                    answer.Append(alphabetLower[c - 97]);
                    continue;
                }
                if (char.IsUpper(c))
                {
                    answer.Append(alphabetUper[c - 65]);
                    continue;
                }
                answer.Append(c);
            }
            return answer.ToString();
        }
    }
}