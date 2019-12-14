using System;

namespace Katas
{
    public class SimpleFun_97_VideoPart
    {
        public int[] VideoPart(string part, string total){
            int partInt = (Int32.Parse(part.Split(":")[0]) * 60
                          + Int32.Parse(part.Split(":")[1])) * 60
                          + Int32.Parse(part.Split(":")[2]);
            int totalInt = (Int32.Parse(total.Split(":")[0]) * 60
                           + Int32.Parse(total.Split(":")[1])) * 60
                          + Int32.Parse(total.Split(":")[2]);
            return new []{partInt / GCD(partInt, totalInt), totalInt / GCD(partInt, totalInt)};
        }

        static int GCD(int a, int b)
        {
            if (a == 0)
                return b;
            return GCD(b % a, a);
        }
    }
}