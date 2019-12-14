using System;

namespace Katas
{
    public class SimpleFun_158_NotSoRandom
    {
        static void Main(string[] args)
        {

        }

        public string NotSoRandom(double b, double w)
        {
            return ((uint)b % 2 == 1)?"Black":"White";
        }
    }
}