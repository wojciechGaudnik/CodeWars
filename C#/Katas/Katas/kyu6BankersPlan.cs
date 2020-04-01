using System;

namespace Katas
{
    public class kyu6BankersPlan
    {

        public static Boolean Fortune(int f0, double p, int c0, int n, double i)
        {
            Console.WriteLine("--->" + f0 + "<->" + p + "<->" + c0 + "<->" + n + "<->" + i + "<---");
            var pd = (decimal) (p * 0.01);
            var id = (decimal) (i * 0.01);
            while (f0 > 0 && --n > 0)
            {
                f0 = (int)(f0 + f0 * pd - c0);
                c0 += (int)(c0 * id);
            }
            return f0 >= 0;
        }

        public static Boolean Fortune2(int f0, double p, int c0, int n, double i)
        {
            Console.WriteLine("--->" + f0 + "<->" + p + "<->" + c0 + "<->" + n + "<->" + i + "<---");
            decimal f0d = f0;
            var pd = (decimal) (p * 0.01);
            var id = (decimal) (i * 0.01);
            while (f0d > 0 && --n > 0)
            {
                f0d = f0d + f0d * pd - c0;
                c0 += (int)(c0 * id);
            }

            Console.WriteLine(f0d);
            return f0d >= 0;
        }
    }
}