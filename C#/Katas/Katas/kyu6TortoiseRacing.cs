namespace Katas
{
    public class kyu6TortoiseRacing
    {
        public static int[] Race(int v1, int v2, int g)
        {
            if(v1 >= v2) return null;
            var time = (g * 3600) / (v2 - v1);
            var h = time / 3600;
            var min = (time % 3600) / 60;
            var sec = time % 60;
            return new[] {h, min, sec };
        }


    }
}