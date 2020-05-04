using System;

namespace Katas
{
    public class kyu6CalculateTheAreaOfARegularNSidesPolygonInsideACircleOfRadiusR
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(AreaOfPolygonInsideCircle(8, 5));
            Console.WriteLine(AreaOfPolygonInsideCircle(3, 3));
            Console.WriteLine(AreaOfPolygonInsideCircle(11.936299781751, 19));
            var radians = (Math.PI / 180) * 36;
            var test = Math.Sin(radians);

            // Console.WriteLine(test);
            // Console.WriteLine(test2);
        }

        public static double AreaOfPolygonInsideCircle(double circleRadius, int numberOfSides)
        {
            var alpha = (Math.PI / 180) * (double) decimal.Divide(decimal.Divide(360, numberOfSides), 2);
            var b = 2 * Math.Sin(alpha) * circleRadius;
            var h = Math.Cos(alpha) * circleRadius;
            return Math.Round((0.5 * b * h) * numberOfSides, 3);
        }
    }
}