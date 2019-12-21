using System.Linq;

namespace Katas
{
    public class DecodeTheMorseCode
    {
        public static string Decode(string morseCode)
        {
            return string.Join(" ", morseCode
                .Split("  ")
                .Select(w => string
                    .Join("", w
                        .Split(" ")
                        .Select(Get))))
                .Trim();
        }

        public static string Get(string w)
        {
            return "A";
        }
    }
}