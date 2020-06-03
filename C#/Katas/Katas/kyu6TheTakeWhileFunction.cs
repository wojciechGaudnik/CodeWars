using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6TheTakeWhileFunction
    {
        public static void Main(string[] args)
        {
            Func<int, bool> isEven = (num) => num % 2 == 0;
            Console.WriteLine(string.Join(", ", TakeWhile(new int[] { 2,6,4,10,1,5,4,3 }, isEven)));
            Console.WriteLine(string.Join(", ", TakeWhile(new int[] { 172, 47, 105, -147, -27, -42, 46 }, isEven)));

        }

        public static int[] TakeWhile(int[] arr, Func<int,bool> pred)
        {
            if(arr == null || arr.Length == 0 || !pred(arr[0])) return new int[0];
            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine(string.Join(", ", arr.Where(pred)));
            var answer = new List<int>();
            answer.Add(arr[0]);
            for (var i = 1; i < arr.Length; i++)
            {
                if(!pred(arr[i])) break;
                answer.Add(arr[i]);
            }
            return answer.ToArray();
        }
    }
}