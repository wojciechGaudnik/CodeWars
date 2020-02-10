using System;
using System.Linq;

namespace Katas
{
    public class kyu6ConsecutiveStrings
    {
        public static String LongestConsec(string[] strarr, int k)
        {
            if (k > strarr.Length || k == 0) return "";
            var max = 0;
            var index = 0;
            for (var i = 0; i <= strarr.Length - k; i++)
            {
                var tempMax = 0;
                for (var tempI = i; tempI < k + i; tempI++)
                {
                    tempMax += strarr[tempI].Length;
                }
                if (tempMax <= max) continue;
                max = tempMax;
                index = i;
            }
            return string.Join("", strarr.Skip(index).Take(k));
        }
    }
}