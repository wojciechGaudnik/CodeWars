using System.Linq;

namespace Katas
{
    public class kyu5RGBToHexConversion
    {
        public static string Rgb(int r, int g, int b)
        {
            var arr = new [] {r, g, b};
            return string.Join("",arr
                .Select(n => (n < 0) ? 0 : (n > 255) ? 255 : n)
                .Select(n => n.ToString("X"))
                .Select(n => (n.Length == 1) ? "0" + n: n).ToArray());
        }


    }
}