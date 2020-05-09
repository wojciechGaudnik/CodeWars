namespace Katas
{
    public class kyu6NumberFormat
    {
        public static string NumberFormat(int number)
        {
            var numberStr = number.ToString();
            for (var i = numberStr.Length - 3; i > 0; i -= 3) numberStr = numberStr.Insert(i, ",");
            return numberStr.Contains("-,") ? numberStr.Replace("-,", "-") : numberStr;
            // return number.ToString("N0");
        }
    }
}