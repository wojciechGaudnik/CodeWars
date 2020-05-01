using System;

namespace Katas
{
    public class kyu6ShortestStepsToANumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(ShortestStepsToNum(71));
        }

        public static int ShortestStepsToNum(int num)
        {
            var answer = 0;
            while (num != 1)
            {
                answer++;
                if (num % 2 == 0) num /= 2;
                else num--;
            }
            return answer;
        }
    }
}