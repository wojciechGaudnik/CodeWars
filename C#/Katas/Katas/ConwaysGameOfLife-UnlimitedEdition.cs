namespace Katas
{
    public class ConwaysGameOfLife_UnlimitedEdition
    {
        public static int[,] GetGeneration(int[,] cells, int generation)
        {
            if (generation < 1) return Crop(cells);

            var YLength = cells.GetUpperBound(0);
            var XLength = cells.GetUpperBound(1);
            var YLengthRezized = YLength + 3;
            var XLengthRezized = XLength + 3;

            var resized = new int [YLengthRezized, XLengthRezized];
            for (var yCells = 0; yCells <= YLength; yCells++)
            {
                for (var xCells = 0; xCells <= XLength; xCells++)
                {
                    resized[yCells + 1, xCells + 1] = cells[yCells, xCells];
                }
            }

            var nextCells = new int [YLengthRezized, XLengthRezized];
            int cell, weight, x, y, endx, endy;
            bool searchabove, searchbelow, searchleft, searchright;
            for (var i = 0; i < YLengthRezized; i++)
            {
                searchabove = i - 1 >= 0;
                searchbelow = i + 1 < YLengthRezized;

                for (var j = 0; j < XLengthRezized; j++)
                {
                    searchleft = j - 1 >= 0;
                    searchright = j + 1 < XLengthRezized;

                    cell = resized[i, j];
                    weight = 0;
                    if (searchabove) x = i - 1;
                    else x = i;
                    if (searchbelow) endx = i + 1;
                    else endx = i;
                    if (searchleft) y = j - 1;
                    else y = j;
                    if (searchright) endy = j + 1;
                    else endy = j;

                    for (; x <= endx; x++)
                    for (var p = y; p <= endy; p++)
                        weight += resized[x, p];

                    weight -= cell;

                    switch (cell)
                    {
                        case 1 when (weight < 2 || weight > 3):
                            nextCells[i, j] = 0;
                            break;
                        case 0 when weight == 3:
                            nextCells[i, j] = 1;
                            break;
                        default:
                            nextCells[i, j] = cell;
                            break;
                    }
                }
            }

            nextCells = Crop(nextCells);
            return GetGeneration(nextCells, generation - 1);
        }

        private static int[,] Crop(int[,] cells)
        {
            var boundY = cells.GetUpperBound(0);
            var boundX = cells.GetUpperBound(1);
            int minX = boundX, maxX = 0, minY = boundY, maxY = 0;
            for (var y = 0; y <= boundY; y++)
            {
                for (var x = 0; x <= boundX; x++)
                {
                    if (cells[y, x] != 1) continue;
                    if (y < minY) minY = y;
                    if (y > maxY) maxY = y;
                    if (x < minX) minX = x;
                    if (x > maxX) maxX = x;
                }
            }

            var crop = new int[maxY - minY + 1, maxX - minX + 1];
            for (var y = minY; y <= maxY; y++)
            {
                for (var x = minX; x <= maxX; x++)
                {
                    crop[y - minY, x - minX] = cells[y, x];
                }
            }
            return crop;
        }
    }
}