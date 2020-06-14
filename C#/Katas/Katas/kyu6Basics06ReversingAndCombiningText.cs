using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6Basics06ReversingAndCombiningText
    {
        public string reverseAndCombineText(string text)
        {
            if (text.Split(" ").Length == 1) return text;
            var newText = text.Split(" ");
            while (newText.Length > 1)
            {
                var lastWord = "";
                if (newText.Length % 2 == 1)
                {
                    lastWord = string.Join("", newText[^1].Reverse().ToArray());
                    newText = newText.Take(newText.Length - 1).ToArray();
                }

                var newTextBuff = new LinkedList<string>();
                for (var i = 0; i < newText.Length - 1; i += 2)
                {
                    var newWord =
                        string.Join("", newText[i].Reverse().ToArray()) +
                        string.Join("", newText[i + 1].Reverse().ToArray());
                    newTextBuff.AddLast(newWord);
                }
                if (lastWord != "") newTextBuff.AddLast(lastWord);
                newText = newTextBuff.ToArray();
            }
            return newText[0];
        }
    }
}