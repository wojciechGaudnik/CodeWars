using System.Text;

namespace Katas
{
    public class kyu6SimpleEncryption_1_AlternatingSplit
    {
        public static string Encrypt(string text, int n)
        {
            if(n < 1) return text;
            if(text == null) return null;
            var answer = new StringBuilder(text);
            while (n-- > 0)
            {
                var partOne = new StringBuilder();
                var partTwo = new StringBuilder();
                for (var i = 1; i < text.Length; i += 2)
                {
                    partOne.Append(answer[i]);
                }
                for (var i = 0; i < text.Length; i += 2)
                {
                    partTwo.Append(answer[i]);
                }
                answer = new StringBuilder(partOne.ToString() + partTwo);
            }
            return answer.ToString();
        }

        public static string Decrypt(string encryptedText, int n)
        {
            if(n < 1) return encryptedText;
            if(encryptedText == null) return null;
            StringBuilder answer = new StringBuilder();
            while (n-- > 0)
            {
                answer = new StringBuilder(encryptedText.Length);
                for (int x = 0, i = 0, j = encryptedText.Length / 2; x < encryptedText.Length; i++, j++, x++)
                {
                    answer.Insert(x++, encryptedText[j]);
                    if(x >= encryptedText.Length) break;
                    answer.Insert(x, encryptedText[i]);
                }
                encryptedText = answer.ToString();
            }
            return answer.ToString();
        }
    }

}