using System;

namespace Katas
{
    public class kyu6BallUpwards
    {
        public static int MaxBall(int v0)
        {
            var v = Decimal.Divide(v0 * 5, 18);
            var max = new decimal(-1);
            var h = new decimal(0);
            var t = new decimal(0.1);
            var g = new decimal(9.81);
            var i = 0;
            while (h > max)
            {
                max = h;
                h = (v * t) - new decimal(0.5) * g * t * t;
                t += (decimal) 0.1;
                i++;
            }
            return i - 1;
        }
    }
}