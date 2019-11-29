namespace Katas
{
    public class ShortLongShort
    {
        public static string Solution(string a, string b)
        {
            return (a.Length > b.Length)?b + a + b: a + b + a;
        }
    }
}