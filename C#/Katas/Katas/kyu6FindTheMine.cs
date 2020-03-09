using System;

namespace Katas
{
    public class kyu6FindTheMine
    {
        public static Tuple<int, int> MineLocation(int[,] field)
        {
            var size = (int)Math.Sqrt(field.Length);
            for (var y = 0; y < size; y++)
            {
                for (var x = 0; x < size; x++)
                {
                    if(field[y,x] == 1) return Tuple.Create(y,x);
                }
            }
            return null;
        }
    }
}