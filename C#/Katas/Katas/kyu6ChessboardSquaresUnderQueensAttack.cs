namespace Katas
{
    public class kyu6ChessboardSquaresUnderQueensAttack
    {
        public int ChessboardSquaresUnderQueenAttack(int y,int x)
        {
            var count = 0;
            count = HorizontalAndVertical(y, x);
            count += (4 * QuarterOblique(y, x));
            if(y % 2 != 0) count += OddHorizontalOblique(y, x);
            if(x % 2 != 0) count += OddVerticalOblique(y, x);
            if(y % 2 != 0 && x % 2 != 0) count -= Oblique(y, x, y / 2, x / 2);
            return count;

        }

        public static int HorizontalAndVertical(int y, int x)
        {
            return (((x - 1) + (y - 1))) * x * y;
        }

        public static int QuarterOblique(int y, int x)
        {
            var oy = y / 2;
            var ox = x / 2;
            var count = 0;
            for (var iy = 0; iy < oy; iy++)
            {
                for (var ix = 0; ix < ox; ix++)
                {
                    count += Oblique(y, x, iy, ix);
                }
            }

            return count;
        }

        public static int OddHorizontalOblique(int y, int x)
        {
            var middleY = (y / 2);
            var count = 0;
            for (var ox = 0; ox < x; ox++)
            {
                count += Oblique(y, x, middleY, ox);
            }
            return count;
        }

        public static int OddVerticalOblique(int y, int x)
        {
            var middleX = (x / 2);
            var count = 0;
            for (var oy = 0; oy < y; oy++)
            {
                count += Oblique(y, x, oy, middleX);
            }
            return count;

        }

        private static int Oblique(int y, int x, int cy, int cx)
        {
            var count = 0;
            var calcy = 0;
            var calcx = 0;
            calcy = y - cy - 1;
            calcx = x - cx - 1;
            count += (cy > calcx) ?calcx: cy;
            count += (calcx > calcy) ?calcy: calcx;
            count += (calcy > cx) ?cx: calcy;
            count += (cx > cy) ?cy: cx;
            return count;
        }
    }
}