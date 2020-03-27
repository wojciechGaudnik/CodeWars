using System;
using System.Collections.Generic;

namespace Katas
{
    public class kyu6ClockInMirror
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(WhatIsTheTime("09:00"));
            Console.WriteLine(WhatIsTheTime("10:00"));
            Console.WriteLine(WhatIsTheTime("11:00"));
            Console.WriteLine(WhatIsTheTime("12:00"));
            Console.WriteLine(WhatIsTheTime("01:00"));
            Console.WriteLine(WhatIsTheTime("02:00"));
            Console.WriteLine(WhatIsTheTime("03:00"));
            // Console.WriteLine(WhatIsTheTime("12:22"));
            // Console.WriteLine(WhatIsTheTime("11:38"));
            // Console.WriteLine(WhatIsTheTime("11:30"));
            Console.WriteLine(WhatIsTheTime("05:25").Equals("06:35"));
            Console.WriteLine(WhatIsTheTime("05:25"));
        }

        public static string WhatIsTheTime(string timeInMirror)
        {
            var hours = int.Parse(timeInMirror.Split(":")[0]);
            var minutes = int.Parse(timeInMirror.Split(":")[1]);
            if (hours == 12 && minutes == 0 || hours == 6 && minutes == 0 || hours == 12 && minutes == 30 ||
                hours == 6 && minutes == 30)
            {
                return timeInMirror;
            }

            Dictionary<int, int> dictionary;


            if (minutes == 0)
            {
                dictionary = new Dictionary<int, int>
                {
                    {12, 12},
                    {1, 11},
                    {2, 10},
                    {3, 9},
                    {4, 8},
                    {5, 7},
                    {6, 6},
                    {7, 5},
                    {8, 4},
                    {9, 3},
                    {10, 2},
                    {11, 11},
                };
            }
            else
            {
                dictionary = new Dictionary<int, int>
                {
                    {12, 11},
                    {1, 10},
                    {2, 9},
                    {3, 8},
                    {4, 7},
                    {5, 6},
                    {6, 5},
                    {7, 4},
                    {8, 3},
                    {9, 2},
                    {10, 1},
                    {11, 12},
                };
            }


            if (minutes != 0)
            {
                minutes += (30 - minutes) * 2;
            }
            return $"{dictionary[hours],-2:00}:{minutes,-2:00}";
        }
    }
}