using System;
using System.Linq;

namespace Katas
{
    public class kyu6BasicEncryption
    {
        public static void Main(string[] args)
        {
        }

        public static string Encrypt(string text, int rule)
        {
            return string.Join("", text.Select(c => (char)((c + rule) % 256)));
        }
    }
}