using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class kyu6FilePathOperations { }

    public class FileMaster
    {
        private string filePath;

        public FileMaster(string filepath)
        {
            Console.WriteLine(filepath);
            filePath = filepath;
        }

        public string extension()
        {
            return filePath.Split(".")[1];
        }
        public string filename()
        {
            Regex regex = new Regex("\\/\\w+\\.");
            var matches = regex.Matches(filePath).First();
            return string.Join("", matches.Value.Skip(1).Take(matches.Value.Length - 2));
        }
        public string dirpath()
        {
            return filePath.Replace(filename() + "." + extension(), "");
        }
    }
}