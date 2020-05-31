using System;

namespace Katas
{
    public class kyu4SimpleFun27RectangleRotation
    {
        public static void Main(string[] args)
        {
            var test = new kyu4SimpleFun27RectangleRotation();
            Console.WriteLine(test.RectangleRotation(6, 4));
        }
        public int RectangleRotation(int a, int b)
        {
            var c = (decimal)Math.Sqrt(2);
            var a0 = 1 + (int)((a / 2) / c) * 2;
            var b0 = 1 + (int)((b / 2) / c) * 2;
            var complete0 = a0 * b0;

            var a1 = (int)((((a / (decimal)2.0) - (c / (decimal)2.0)) / c) + 1) * 2;
            var b1 = (int)((((b / (decimal)2.0) - (c / (decimal)2.0)) / c) + 1) * 2;
            var complete1 = a1 * b1;
            return complete0 + complete1;
        }

    }
}