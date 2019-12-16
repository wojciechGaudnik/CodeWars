using System;

namespace Katas
{
    public class SimpleFun_162_PairWise
    {
        public int Pairwise(int[] arr, int n)
        {
            var sum = 0;
            for (var i = 0; i < arr.Length - 1; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] != -1 && arr[j] != -1 && arr[i] + arr[j] == n)
                    {
                        sum += i + j;
                        arr[i] = -1;
                        arr[j] = -1;
                    }
                }
            }
            return sum;
        }
    }
}