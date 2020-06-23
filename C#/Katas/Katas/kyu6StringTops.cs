using System;
using System.Text;

namespace Katas
{
    public class kyu6StringTops
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Tops("abcdefghijklmnopqrstuvwxyz12345"));

        }

        public static string Tops(string msg)
        {
            if (string.Empty == msg) return string.Empty;
            if (msg.Length == 1) return msg;
            var top = 1;
            var diff = 1;
            var answer = new StringBuilder();
            while (top < msg.Length)
            {
                answer.Insert(0, msg[top]);
                diff += 4;
                top += diff;
            }
            return answer.ToString();
        }

    }
}