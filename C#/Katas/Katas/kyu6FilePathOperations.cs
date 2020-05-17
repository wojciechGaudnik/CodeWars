using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class kyu6FilePathOperations { }

    public class FileMaster
    {

        public static void Main(string[] args)
        {
            var test = "/Users/person1/Pictures/house.png";
            var testFileMaster = new FileMaster("lllwms/vbvufx/ryctaw/xwpidn/glpeva/mvlocy.xyz");
            Console.WriteLine(testFileMaster.extension());
            Console.WriteLine(testFileMaster.filename());
            Console.WriteLine(testFileMaster.dirpath());


            // Regex regex = new Regex("^.+\\/");
            // foreach (Match one in regex.Matches(test))
            // {
            //     Console.WriteLine(string.Join("", one.Value.Skip(1).Take(one.Value.Length - 2)));
            //
            // }
        }

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