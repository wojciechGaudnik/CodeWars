using System;
using System.Linq;

namespace Katas
{
    public class kyu6Basics08FindNextHigherNumberWithSameBits1s
    {
        public int nextHigher(int value)
        {
            var numberOfOnes = Convert.ToString(value++, 2).Count(c => c == '1');
            while (numberOfOnes != Convert.ToString(value, 2).Count(c => c == '1')) value++;
            return value;
        }
    }
}