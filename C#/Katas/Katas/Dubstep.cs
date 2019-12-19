using System;
using System.Text.RegularExpressions;

namespace Katas
{
    public class Dubstep
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SongDecoder("WUBWUBABCWUB"));
            Console.WriteLine(SongDecoder("RWUBWUBWUBLWUB"));
        }

        public static string SongDecoder(string input)
        {
            return Regex.Replace(input, "(WUB)+", " ").Trim();
        }
    }
}