using System.Text;

namespace Katas
{
    public class kyuencryptThis
    {
        public static string EncryptThis(string input)
        {
            if (input == "") return input;
            var answer = new StringBuilder();
            foreach (var one in input.Split(" "))
            {
                switch (one.Length)
                {
                    case 1:
                        answer.Append(((int) one[0]) + " ");
                        break;
                    case 2:
                        answer.Append((int) (one[0]) + "" + one[1] + " ");
                        break;
                    default:
                        answer.Append(((int) one[0]).ToString() + one[one.Length - 1] +
                                      one.Substring(2, one.Length - 3) + one[1] + " ");
                        break;
                }
            }
            return answer.ToString().Trim();
        }
    }
}