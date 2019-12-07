using System;

public class PlayingOnAChessboard
{
    static void Main(string[] args)
    {
        Console.WriteLine();
    }
    public static string game(long n)
    {
        Console.WriteLine(n);
        if (n == 0) return "[0]";
        if (n % 2 == 0) return ($"[{n * (n / 2)}]");
        return $"[{n * n}, 2]";
    }
}