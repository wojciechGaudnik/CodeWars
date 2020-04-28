using System;

namespace Katas
{
    public class kyu6PizzaPieces
    {
        public static void Main(string[] args)
        {
            // 1-2-4-7-11-16-22
            Console.WriteLine(maxPizza(0));
            Console.WriteLine(maxPizza(1));
            Console.WriteLine(maxPizza(2));
            Console.WriteLine(maxPizza(3));
            Console.WriteLine(maxPizza(4));
        }

        public static int  maxPizza(int cut)
        {
            if (cut < 0) return -1;
            var allPieces = 1;
            var step = 1;
            while (cut-- > 0) allPieces += step++;
            return allPieces;
        }
    }
}