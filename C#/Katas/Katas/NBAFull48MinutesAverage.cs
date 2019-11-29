using System;

namespace Katas
{
    public class NBAFull48MinutesAverage
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NbaExtrap(5,17));
        }

        public static double NbaExtrap(double ppg, double mpg)
        {
            return (ppg == 0)?0:Math.Round((ppg * 48)/mpg, 1);
        }
    }
}