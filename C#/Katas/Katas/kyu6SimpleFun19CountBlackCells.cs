using System;

namespace Katas
{
    public class kyu6SimpleFun19CountBlackCells
    {
        public static void Main(string[] args)
        {
            var test = new kyu6SimpleFun19CountBlackCells();

            Console.WriteLine(test.CountBlackCells(33,44));
            // Console.WriteLine(test.CountBlackCells(3, 4));
            Console.WriteLine(test.CountBlackCells(4, 13));


            var h = 33;
            var w = 44;
            var i = 0;
            var gcd = 0;
            for (i = 1; i < w; i++)
            {

                if (h % i == 0 && w % i == 0)
                {
                    var hi = h / i;
                    var wi = w / i;
                    gcd = i;
                    Console.WriteLine("i=" + i + "  h/i=" + hi + " w/i=" + wi);
                }
            }
            Console.WriteLine("--------------");
            Console.WriteLine(h + w - 1 + gcd - 1);

            h = 8;
            w = 16;
            for (i = 1; i < w; i++)
            {

                if (h % i == 0 && w % i == 0)
                {
                    var hi = h / i;
                    var wi = w / i;
                    gcd = i;
                    Console.WriteLine("i=" + i + "  h/i=" + hi + " w/i=" + wi);
                }
            }
            Console.WriteLine("--------------");
            Console.WriteLine(h + w - 1 + gcd - 1);

            h = 6666;
            w = 8888;
            for (i = 1; i < w; i++)
            {

                if (h % i == 0 && w % i == 0)
                {
                    var hi = h / i;
                    var wi = w / i;
                    gcd = i;
                    Console.WriteLine("i=" + i + "  h/i=" + hi + " w/i=" + wi);
                }
            }

            Console.WriteLine("--------------");
            Console.WriteLine(h + w - 1 + gcd - 1);

        }

        public int CountBlackCells(int h,int w){
            if (h == w) return h + 2 * (h - 1);
            return h + w + GCD(h, w) - 2;
        }

        private static int GCD(int a, int b) => a == 0 ? b : GCD(b % a, a);


    }
}