namespace Katas
{
    public class kyu6ClockyMcClockFace
    {
        public static string WhatTimeIsIt(double angle)
        {
            var hours = (int) angle / 30;
            if (hours == 0) hours = 12;
            var minutes = (int)(angle % 30 * 60) / 30;
            return $"{hours:00}:{minutes:00}";
        }

    }
}