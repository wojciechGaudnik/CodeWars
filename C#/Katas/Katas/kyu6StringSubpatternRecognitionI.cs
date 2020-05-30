namespace Katas
{
    public class kyu6StringSubpatternRecognitionI
    {
        public static bool HasSubpattern(string str)
        {
            for (var i = 1; i < str.Length; i++)
            {
                if(str.Length % i != 0) continue;
                var buffStr = str;
                if (buffStr.Replace(str.Substring(0, i), "").Length == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool HasSubpattern1(string str)
        {
            for (var i = 1; i < str.Length; i++)
            {
                var buffStr = str;
                if (buffStr.Replace(str.Substring(0, i), "").Length == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}