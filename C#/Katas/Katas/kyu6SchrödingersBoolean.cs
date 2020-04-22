using System;

namespace Katas
{
    public class kyu6SchrödingersBoolean
    {
        public static kyu6SchrödingersBoolean omnibool ;

        public static bool operator ==(kyu6SchrödingersBoolean a, bool b)
        {
            return true;
        }

        public static bool operator !=(kyu6SchrödingersBoolean a, bool b)
        {
            return true;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(kyu6SchrödingersBoolean.omnibool == true);
            Console.WriteLine(kyu6SchrödingersBoolean.omnibool == false);
        }


    }
}