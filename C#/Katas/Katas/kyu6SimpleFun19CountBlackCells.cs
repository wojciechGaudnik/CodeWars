namespace Katas
{
    public class kyu6SimpleFun19CountBlackCells
    {
        public int CountBlackCells(int h,int w){
            if (h == w) return h + 2 * (h - 1);
            return h + w + GCD(h, w) - 2;
        }

        private static int GCD(int a, int b) => a == 0 ? b : GCD(b % a, a);


    }
}