using System;
using System.Linq;

namespace Katas
{
    public class kyu6TimeLikeStringFormat
    {
        public static string FormatTime(int hour)
        {
            if (hour < 100 || hour >= 10000) throw new ArgumentException();
            return string.Join("",
                string.Join("",
                        hour.ToString()
                            .Reverse())
                    .Insert(2, ":")
                    .Reverse());
        }
    }
}