using System;

namespace Katas
{
    public class kyu6FindTheDuplicatedNumberInAConsecutiveUnsortedListTougherVersion
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(FindDup(new[] { 8,2,6,3,7,2,5,1,4 }));
        }

        public static int FindDup(int[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j]) return arr[i];
                }
            }
            return -1;
        }
    }
}