using System;

namespace Katas
{
    public class PlayingOnAChessboard
    {
        public static string game(long n)
        {
            Console.WriteLine(n);
            if (n == 0) return "[0]";
            if (n % 2 == 0) return ($"[{n * (n / 2)}]");
            return $"[{n * n}, 2]";
        }
    }
}