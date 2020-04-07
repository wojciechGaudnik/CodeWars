using System;

namespace Katas
{
    public class kyu6ClockyMcClockFace
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(WhatTimeIsIt(0));
            Console.WriteLine(WhatTimeIsIt(360));
            Console.WriteLine(WhatTimeIsIt(90));
            Console.WriteLine(WhatTimeIsIt(180));
            Console.WriteLine(WhatTimeIsIt(270));
            Console.WriteLine(WhatTimeIsIt(341.51d) + " <---11:23" );

        }

        public static string WhatTimeIsIt(double angle)
        {
            var hours = (int) angle / 30;
            if (hours == 0) hours = 12;
            var minutes = (int)(angle % 30 * 60) / 30;
            return $"{hours:00}:{minutes:00}";
        }

    }
}