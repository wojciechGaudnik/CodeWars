using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6VolwelShifting
    {
        public static string VowelShift(string text, int n)
        {
            if (n == 0) return text;
            var listVowels = new ArrayList();
            var listVowelsIndexes = new ArrayList();
            var vowels = new HashSet<char>{'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
            for (var i = 0; i < text.Length; i++)
            {
                if (!vowels.Contains(text[i])) continue;
                listVowels.Add(text[i]);
                listVowelsIndexes.Add(i);
            }

            if(listVowelsIndexes.Count == 0) return text;
            n %= listVowels.Count;
            if (listVowels.Count == Math.Abs(n)) return text;

            var listVowelsBuff = new ArrayList(listVowels);
            for (var i = 0; i < listVowels.Count; i++)
            {
                var iPlusN = i + n;
                if (iPlusN >= listVowels.Count) iPlusN -= listVowels.Count;
                else if(iPlusN <= -1) iPlusN = listVowels.Count + iPlusN;
                listVowels[iPlusN] = listVowelsBuff[i];
            }

            var textArray = text.ToArray();
            for (var i = 0; i < listVowels.Count; i++)
            {
                textArray[(int) listVowelsIndexes[i]] = (char) listVowels[i];
            }
            return string.Join("", textArray);
        }
    }
}