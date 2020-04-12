using System;

namespace Katas
{
    public class kyu6BallUpwards
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine(MaxBall(23));
            Console.WriteLine(PlayerRankUp(99));
            Console.WriteLine(PlayerRankUp(101));

        }

        public static int MaxBall(int v0)
        {
            Console.WriteLine(v0);Console.WriteLine(v0);
            var v = Decimal.Divide(v0 * 5, 18);
            return (int) Math.Round(v / (decimal) 9.81, MidpointRounding.ToEven);
            // return (int) (v / 9.81);
            // var v = Decimal.Divide(v0 * 5, 18);
            // var max = new decimal(-1);
            // var h = new decimal(0);
            // var t = new decimal(0.1);
            // var g = new decimal(9.81);
            // var i = 0;
            // while (h > max)
            // {
            //     h += (v * t) - new decimal(0.5) * g * t * t;
            //     t += (decimal) 0.1;
            //     i++;
            // }
            // return i;
        }

        public static Object PlayerRankUp(int points)
        {
            return (points >= 100)
                ? (object) "Well done! You have advanced to the qualifying stage. Win 2 out of your next 3 games to rank up."
                : false;
        }

    }
}