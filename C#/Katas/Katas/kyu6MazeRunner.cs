using System;
using System.Collections;

namespace Katas
{
    public class kyu6MazeRunner
    {
        private static int[,] maze = new int[,] { { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 0, 0, 0, 0, 0, 3 },
            { 1, 0, 1, 0, 1, 0, 1 },
            { 0, 0, 1, 0, 0, 0, 1 },
            { 1, 0, 1, 0, 1, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 1 },
            { 1, 2, 1, 0, 1, 0, 1 } };

        public static void Main(string[] args)
        {
            string[] directions = new string[] { "N", "N", "N", "N", "N", "E", "E", "E", "E", "E" };
            var test = new kyu6MazeRunner();
            Console.WriteLine(test.mazeRunner(maze, directions));

        }

        public string mazeRunner(int[,] maze, string[] directions)
        {
            var maxY  = maze.GetLength(0);
            var maxX  = maze.GetLength(1);
            var startY = 0;
            var startX = 0;

            for (var y = 0; y < maxY; y++)
            {
                for (var x = 0; x < maxX; x++)
                {
                    if (maze[y, x] != 2) continue;
                    startY = y;
                    startX = x;
                }
            }

            foreach (var one in directions)
            {
                if (one == "N") startY--;
                if (one == "E") startX++;
                if (one == "S") startY++;
                if (one == "W") startX--;
                if (startX < 0 || startX >= maxX || startY < 0 || startY >= maxY || maze[startY, startX] == 1) return "Dead";
                if (maze[startY, startX] == 3) return "Finish";
            }
            return "Lost";
        }
    }
}