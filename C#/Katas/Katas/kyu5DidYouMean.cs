using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    public class kyu5DidYouMean
    {
        public static void Main(string[] args)
        {

        }
        
        private IEnumerable<string> words;

        public kyu5DidYouMean(IEnumerable<string> words)
        {
            this.words = words;
        }
        public string FindMostSimilar(string term)
        {
            var dictSorted = new SortedDictionary<string, int>();

            foreach (var wordDictionary in words)
            {
                var points = 0;
                var wordDictionaryBuff = new StringBuilder(wordDictionary);
                var wordToFindBuff = new StringBuilder(term);
                var lengthBuff = 0;
                while (lengthBuff != wordToFindBuff.Length)
                {
                    lengthBuff = wordToFindBuff.Length;
                    var (index, length,theSameIndex) = TwoWords(wordToFindBuff.ToString(), wordDictionaryBuff.ToString());
                    if(index == -1) break;
                    if(length > 1) points += ((length * theSameIndex) * 2);
                    else points += (length * theSameIndex);
                    var toRemove = wordDictionaryBuff.ToString().Substring(index, length);
                    wordDictionaryBuff.Remove(index, length);
                    wordToFindBuff.Replace(toRemove, "");
                }
                dictSorted.Add(wordDictionary, points - wordDictionary.Length);
            }
            return dictSorted.OrderByDescending(e => e.Value).First().Key;
        }

        private static (int index, int max, int theSameIndex) TwoWords(string wortToFind, string wordToSearch)
        {
            var max = 0;
            var index = -1;
            var theSameIndex = 1;
            for (var i = 0; i < wortToFind.Length; i++)
            {
                var iBuff = i;
                var testStart = false;
                var count = 0;
                var indexBuff = 0;
                var theSameIndexBuff = 1;
                for (var j = 0; j < wordToSearch.Length && i < wortToFind.Length; j++)
                {
                    if (wortToFind[i] == wordToSearch[j] && !testStart)
                    {
                        theSameIndexBuff = i == j ? 2 : 1;
                        (testStart, indexBuff) = (true, j);
                        count++;
                        i++;
                        continue;
                    }
                    if (wortToFind[i] == wordToSearch[j] && testStart)
                    {
                        count++;
                        i++;
                        continue;
                    }
                    if (!testStart) continue;
                    i = iBuff;
                    break;
                }
                if (count <= max) continue;
                max = count;
                index = indexBuff;
                theSameIndex = theSameIndexBuff;
                i = iBuff;
            }
            return (index, max, theSameIndex);
        }
    }
}