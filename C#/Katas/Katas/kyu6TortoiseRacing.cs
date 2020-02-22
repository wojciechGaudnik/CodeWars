using System;

namespace Katas
{
    public class kyu6TortoiseRacing
    {
        public static void Main(string[] args)
        {
            var v1 = 720;
            var v2 = 850;
            var g = 70;
            var time = (g * 3600) / (v2 - v1);
            var h = time / 3600;
            var min = (time % 3600) / 60;
            var sec = time % 60;
            Console.WriteLine(h);
            Console.WriteLine(min);
            Console.WriteLine(sec);


        }

        public static int[] Race(int v1, int v2, int g)
        {
            if(v1 >= v2) return null;
            var time = (g * 3600) / (v2 - v1);
            var h = time / 3600;
            var min = (time % 3600) / 60;
            var sec = time % 60;
            return new[] {h, min, sec };
        }


    }
}