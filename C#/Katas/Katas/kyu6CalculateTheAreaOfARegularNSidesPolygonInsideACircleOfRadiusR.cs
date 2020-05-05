using System;

namespace Katas
{
    public class kyu6CalculateTheAreaOfARegularNSidesPolygonInsideACircleOfRadiusR
    {
        public static double AreaOfPolygonInsideCircle(double circleRadius, int numberOfSides)
        {
            var alpha = (Math.PI / 180) * (double) decimal.Divide(decimal.Divide(360, numberOfSides), 2);
            var b = 2 * Math.Sin(alpha) * circleRadius;
            var h = Math.Cos(alpha) * circleRadius;
            return Math.Round((0.5 * b * h) * numberOfSides, 3);
        }
    }
}