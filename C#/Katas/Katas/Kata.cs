using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class Kata
    {
        public static int[] GenerateRange(int min, int max, int step)
        {
            return Kata.Generate(min, max, step).ToArray();
        }

        public static IEnumerable<int> Generate(int min, int max, int step)
        {
            for (int i = min; i <= max; i += step)
            {
                yield return i;
            }
        }
    }

    public class People
    {
        public bool IsGood()
        {
            return true;
        }
    }
    
}