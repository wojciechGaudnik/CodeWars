using System;
using System.IO;
using System.Linq;

namespace Katas
{
    public static class FindTheOddInt
    {
        static void Main(string[] args)
        {
            SimpleFun180RepeatAdjacent test = new SimpleFun180RepeatAdjacent();
            var stringMy = "ccccoooooooooooooooooooooooddee";
            Console.WriteLine(test.RepeatAdjacent(stringMy));
            stringMy = "wwwwaaaarrioooorrrrr";
            Console.WriteLine(test.RepeatAdjacent(stringMy));
            var driveTypes = DriveInfo.GetDrives();
            foreach (var driveType in driveTypes)
            {
                Console.WriteLine(driveType);
            }

            Console.WriteLine(find_it(new[] {20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5}));
        }

        // return  seq.First(x => seq.Count(s => s == x) % 2 == 1);
        public static int find_it(int[] seq)
        {
            foreach (var i in seq)
            {
                if (seq.Count(n => n == i) % 2 == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}