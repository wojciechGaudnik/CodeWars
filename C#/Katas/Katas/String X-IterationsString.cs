using System;
using System.Linq;

namespace Katas
{
    public class String_X_IterationsString
    {
        public static string StringFunc(string s, long x)
        {
            if (x == 0) return s;
            var answer = s.ToCharArray();
            var forTest = new char[answer.Length];
            Array.Copy(answer, forTest, answer.Length);
            var count = 0;
            while (x-- > 0)
            {
                answer = RollFor(answer);
                count++;
                if (Enumerable.SequenceEqual(answer, forTest)) break;
            }
            x %= count;
            while (x-- > 0)
            {
                answer = RollFor(answer);
                count++;
            }
            return string.Join("", answer);
        }

        public static char[] RollFor(char[] word)
        {
            var answer = new char[word.Length];
            var i = 0;
            for (int b = 0, l = word.Length - 1; b < l; b++, l--)
            {
                answer[i++] = word[l];
                answer[i++] = word[b];
            }
            if (word.Length % 2 == 1) answer[answer.Length - 1] = word[(word.Length / 2)];
            return answer;
        }

        public static char[] Roll(char[] word, int n)
        {
            if (n >= word.Length) return word;
            var partFirst = word[Range.EndAt(n)];
            var partSecond = word[Range.StartAt(n)];
            Array.Reverse(partSecond);
            word = partFirst.Concat(partSecond).ToArray();
            return Roll(word, n + 1);
        }
    }
}