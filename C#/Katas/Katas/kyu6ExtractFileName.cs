using System;
using System.Text.RegularExpressions;

namespace Katas
{
    public class kyu6ExtractFileName
    {
        public static string ExtractFileName(string dirtFileName)
        {
            Console.WriteLine(dirtFileName);
            return Regex.Match(dirtFileName, "(?<=_)[0-9A-Za-z_-]+.+?[0-9A-Za-z_-]+").Value;
        }
    }
}