using System;

namespace Katas
{
    public class kyu5Base64Encoding
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(ToBase64("this is a string!!"));
            Console.WriteLine(FromBase64("dGhpcyBpcyBhIHN0cmluZyEh"));

        }

        public static string ToBase64(string s) =>
            Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(s));

        public static string FromBase64(string s) =>
            System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(s));

    }


}