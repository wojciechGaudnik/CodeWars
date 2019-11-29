using System;

namespace Katas
{
    public class CompareWithinMargin
    {
        public static int CloseCompare(double a, double b, double margin = 0)
        {
            if (Math.Abs(a - b) > margin)
            {
                if ((a - b) < 0) return -1;
                if ((a - b) > 0) return 1;
            }
            return 0;
        }
    }
}