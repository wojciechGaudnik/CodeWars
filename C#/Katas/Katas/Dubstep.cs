using System.Text.RegularExpressions;

namespace Katas
{
    public class Dubstep
    {
        public static string SongDecoder(string input)
        {
            return Regex.Replace(input, "(WUB)+", " ").Trim();
        }
    }
}