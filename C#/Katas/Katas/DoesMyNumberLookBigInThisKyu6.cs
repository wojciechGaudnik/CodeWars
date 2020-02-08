using System;

namespace Katas
{
    public class DoesMyNumberLookBigInThisKyu6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Narcissistic(153));
        }

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