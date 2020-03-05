using System;

namespace Katas
{
    public class kyu6CalculateTheFunctionf_x_ForaSimpleLinearSequenceMedium
    {
        public static Func<int, int> GetFunction(int[] sequence)
        {
            var diff = 0;
            if (sequence[2] - sequence[1] == sequence[1] - sequence[0])
            {
                diff = sequence[2] - sequence[1];
            }

            for (var i = 0; i < 4; i++)
            {
                if(sequence[i] + diff != sequence[i + 1]) throw new ArgumentException();
            }

            return x => diff * x + sequence[0];
        }
    }
}