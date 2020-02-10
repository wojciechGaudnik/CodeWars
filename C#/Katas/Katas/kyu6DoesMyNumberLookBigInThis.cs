using System;

namespace Katas
{
    public class kyu6DoesMyNumberLookBigInThis
    {
        public static bool Narcissistic(int value)
        {
            var sum = 0;
            var numberLength = value.ToString().Length;
            foreach (var one in value.ToString())
            {
                sum += (int) Math.Pow(int.Parse(one.ToString()), numberLength);
            }
            return sum == value;
        }
    }
}