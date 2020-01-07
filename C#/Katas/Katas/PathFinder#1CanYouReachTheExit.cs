namespace Katas
{
    public class PathFinder_1CanYouReachTheExit
    {
        public static bool PathFinder(string maze)
        {
            if (maze.Length == 1) return true;
            var mazeSplit = maze.Split("\n");
            var mazeIn = new int[mazeSplit.Length][];
            for (var y = 0; y < mazeSplit.Length; y++)
            {
                mazeIn[y] = new int[mazeSplit[y].Length];
                for (var x = 0; x < mazeSplit[y].Length; x++)
                {
                    mazeIn[y][x] = (mazeSplit[y][x] == '.') ? 0 : 1;
                }
            }

            mazeIn[0][0] = 2;
            if (mazeIn[0][1] == 0) mazeIn[0][1] = 2;
            if (mazeIn[1][0] == 0) mazeIn[1][0] = 2;

            bool test = true;
            while (test)
            {
                test = false;
                for (var y = 0; y < mazeIn.Length; y++)
                {
                    for (var x = 0; x < mazeIn[y].Length; x++)
                    {
                        if (mazeIn[y][x] == 2 && x < mazeIn[y].Length - 1 && mazeIn[y][x + 1] == 0)
                        {
                            mazeIn[y][x + 1] = 2;
                            test = true;
                        }

                        if (mazeIn[y][x] == 2 && y > 0 && mazeIn[y - 1][x] == 0)
                        {
                            mazeIn[y - 1][x] = 2;
                            test = true;
                        }

                        if (mazeIn[y][x] == 2 && x > 0 && mazeIn[y][x - 1] == 0)
                        {
                            mazeIn[y][x - 1] = 2;
                            test = true;
                        }

                        if (mazeIn[y][x] == 2 && y < mazeIn.Length - 1 && mazeIn[y + 1][x] == 0)
                        {
                            mazeIn[y + 1][x] = 2;
                            test = true;
                        }

                        if (mazeIn[mazeIn.Length - 2][mazeIn[0].Length - 1] == 2) return true;
                        if (mazeIn[mazeIn.Length - 1][mazeIn[0].Length - 2] == 2) return true;
                    }
                }
            }


            if (mazeIn[mazeIn.Length - 2][mazeIn[0].Length - 1] == 2) return true;
            return mazeIn[mazeIn.Length - 1][mazeIn[0].Length - 2] == 2;
        }
    }
}