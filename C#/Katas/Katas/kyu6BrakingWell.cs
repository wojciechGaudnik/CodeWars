using System;
using System.Threading;

namespace Katas
{
    public class kyu6BrakingWell
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Dist(144, 0.3));
        }

        private static double g = 9.81;

        public static double Dist(double v, double mu) 		  // suppose reaction time is 1
        {
            var t = 1;
            var vms = (v * 5) / 18;
            return ((vms * vms) / (2 * mu * g)) + (vms * t);
        }
        public static double Speed(double d, double mu) 	  // suppose reaction time is 1
        {
            var mug = -2 * mu * g;
            return (3.6 * (mug + Math.Sqrt(mug * mug - 4 * mug * d)) / 2);
        }
    }
}