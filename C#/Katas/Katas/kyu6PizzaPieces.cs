namespace Katas
{
    public class kyu6PizzaPieces
    {
        public static int  maxPizza(int cut)
        {
            if (cut < 0) return -1;
            var allPieces = 1;
            var step = 1;
            while (cut-- > 0) allPieces += step++;
            return allPieces;
        }
    }
}