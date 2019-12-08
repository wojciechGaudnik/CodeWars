using System;

public class PlayingOnAChessboard
{
    public static string game(long n)
    {
        Console.WriteLine(n);
        if (n == 0) return "[0]";
        if (n % 2 == 0) return ($"[{n * (n / 2)}]");
        return $"[{n * n}, 2]";
    }

    static void Main(string[] args)
    {
        Console.WriteLine(pageCount(5, 4));
    }

    static int pageCount(int n, int p)
    {
        if (n % 2 == 0) n++;
        if (p % 2 == 0) p++;
        return (p - 1 < n - p)? (p - 1) / 2: (n - p) / 2;
    }
}