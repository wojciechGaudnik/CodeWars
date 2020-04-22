using System;

namespace Katas
{
    public class kyu6ZeroFillFor_theQueen
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(ZeroFill(666, 10));
            Console.WriteLine(string.Format("{0:D5}", 4));
        }

        public static string ZeroFill(int number, int size)
        {
            // var numberString = Math.Abs(number).ToString();
            // if(numberString.Length >= size) return numberString;
            // return new String('0', size - numberString.Length) + numberString;
            return string.Format("{0:D" + size.ToString() + "}", Math.Abs(number));
        }


    }
}