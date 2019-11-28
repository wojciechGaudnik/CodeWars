namespace myjinxin
{
    using System;

    public class Kata
    {
        public int GrowingPlant(int UpSpeed, int DownSpeed, int DesiredHeight)
        {
            var height = 0;
            var count = 0;
            for (;;)
            {
                count++;
                height += UpSpeed;
                if(height >= DesiredHeight) return count;
                height -= DownSpeed;
            }
        }
    }
}