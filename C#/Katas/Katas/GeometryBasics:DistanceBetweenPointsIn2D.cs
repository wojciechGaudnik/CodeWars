using System;
using System.Drawing;

namespace Katas
{
    public class GeometryBasics_DistanceBetweenPointsIn2D
    {
        public static double DistanceBetweenPoints(Point a, Point b)
        {
            double x1 = a.X;
            double y1 = a.Y;
            double x2 = b.X;
            double y2 = b.Y;
            return Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)), 6);
        }
    }
}