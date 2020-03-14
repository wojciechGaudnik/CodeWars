using System;

namespace Katas
{
    public class kyu6CalculateHypotenuseOfRight_angledTriangle
    {

        public static double CalculateHypotenuse(double a, double b)
        {
            if(double.IsNaN(a) || double.IsNaN(b) || a <= 0 || b <=0) throw new ArgumentException();
            return Convert.ToDouble(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)).ToString("N3"));
        }

    }
}