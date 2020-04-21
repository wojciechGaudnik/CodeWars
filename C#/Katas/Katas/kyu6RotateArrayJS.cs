using System;

namespace Katas
{
    public class kyu6RotateArrayJS
    {
        public static void Main(string[] args)
        {
            var data = new object[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(",", Rotate(data, 2)));
            // Console.WriteLine(string.Join(",", Rotate(data, 6)));
        }

        public static object[] Rotate(object[] array, int n)
        {
            object[] answer = new object[array.Length];
            Array.Copy(array, answer, array.Length);
            if (n > 0)
            {
                if(n > answer.Length) n %= answer.Length;
                while (n-- > 0) answer = RotateRight(answer);
                return answer;
            }
            if (n < 0)
            {
                n = Math.Abs(n);
                if(n > answer.Length) n %= answer.Length;
                while (n-- > 0) answer = RotateLeft(answer);
                return answer;
            }
            return answer;
        }

        private static object[] RotateLeft(object[] array)
        {
            var first = array[0];
            for (var i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = first;
            return array;
        }

        private static object[] RotateRight(object[] array)
        {
            var last = array[array.Length - 1];
            for (var i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = last;
            return array;
        }
    }
}