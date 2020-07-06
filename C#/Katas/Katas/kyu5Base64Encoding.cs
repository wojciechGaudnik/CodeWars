using System;

namespace Katas
{
    public class kyu5Base64Encoding
    {
        public static string ToBase64(string s) =>
            Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(s));

        public static string FromBase64(string s) =>
            System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(s));

    }


}