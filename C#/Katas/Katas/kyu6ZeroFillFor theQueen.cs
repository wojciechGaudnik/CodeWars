using System;

namespace Katas
{
    public class kyu6ZeroFillFor_theQueen
    {
        public static string ZeroFill(int number, int size)
        {
            // var numberString = Math.Abs(number).ToString();
            // if(numberString.Length >= size) return numberString;
            // return new String('0', size - numberString.Length) + numberString;
            return string.Format("{0:D" + size.ToString() + "}", Math.Abs(number));
        }


    }
}