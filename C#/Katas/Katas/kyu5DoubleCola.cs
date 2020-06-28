namespace Katas
{
    public class kyu5DoubleCola
    {
        public static string WhoIsNext(string[] names, long n)
        {
            var doublets = 1;
            while (true)
            {
                foreach (var t in names)
                {
                    n -= doublets;
                    if(n  <= 0) return t;
                }
                doublets *= 2;
            }
        }
    }
}