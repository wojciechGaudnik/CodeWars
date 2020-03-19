using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6EnglishBeggars
    {
        public static int[] Beggars(int[] values, int n)
        {
            // if (values.Length == 0) return values;
            if(n == 0) return new int[] { };
            var zeros = new int[values.Length % n];
            Array.Fill(zeros, 0);
            var valuesFiled = values.Concat(zeros).ToArray();
            var answer = new LinkedList<int>();
            for (var i = 0; i < n; i++)
            {
                var sum = 0;
                for (var j = i; j < valuesFiled.Length; j += n)
                {
                    sum += valuesFiled[j];
                }
                answer.AddLast(sum);
            }
            return answer.ToArray();
        }
    }
}