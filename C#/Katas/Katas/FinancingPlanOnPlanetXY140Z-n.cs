using System;
using System.Linq;

namespace Katas
{
    public class FinancingPlanOnPlanetXY140Z_n
    {


        static void Main(string[] args)
        {
            int[] test = {1,2,3,4,};
            test.Select(x => x).ToList().ForEach(x => Console.Write(x + ", "));
            int x = test[0];
            x = 10;
            Console.WriteLine();
            test.Select(x => x).ToList().ForEach(x => Console.Write(x + ", "));
            ref int x2 =ref test[0];
            x2 = 10;
            Console.WriteLine();
            test.Select(x => x).ToList().ForEach(x => Console.Write(x + ", "));
            Console.WriteLine(finance(1));
            Console.WriteLine(finance(5000));


        }

        public static ulong finance(ulong n)
        {
            ulong answer = 0, last = 0, top = 1, bottom = 1;
            while (bottom <= n)
            {
                last += ++top + ++top -(++bottom);
                answer += last;
            }
            return answer;
        }
    }
}