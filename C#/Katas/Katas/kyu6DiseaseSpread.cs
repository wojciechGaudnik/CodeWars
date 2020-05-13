using System;

namespace Katas
{
    public class kyu6DiseaseSpread
    {
        public static void Main(string[] args)
        {
            var  tm = 14;
            var n = 336;
            var s0 = 996;
            var i0 = 2;
            var b = 0.00206;
            var a = 0.41;
            Console.WriteLine(Epidemic(tm, n, s0, i0, b, a));

        }

        public static int Epidemic(int tm, int n, int s0, int i0, double b, double a)
        {
            var dt = (double) tm / n;
            double sk = s0;
            double ik = i0;
            double rk = 0;
            var maxInfected = ik;
            while (n > 0)
            {
                var sk1 = sk - dt * b * sk * ik;
                var ik1 = ik + dt * (b * sk * ik - a * ik);
                var rk1 = rk + dt * ik * a;
                if (maxInfected < ik1) maxInfected = ik1;
                (sk, ik, rk) = (sk1, ik1,  rk1);
                n--;
            }
            return (int) maxInfected;
        }
    }
}