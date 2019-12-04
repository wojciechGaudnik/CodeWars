using System;

namespace Katas
{
    public class BuyingACar
    {
        public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingPerMonth, double percentLossByMonth) {
            Console.WriteLine(startPriceOld + " " + startPriceNew + " " + savingPerMonth + " " + percentLossByMonth);
            int[] answer = new int[2];
            int savedMoney = 0;
            if (startPriceOld >= startPriceNew) return new[] {0, startPriceOld - startPriceNew};
            double startPriceOldDouble = startPriceOld;
            double startPriceNewDouble = startPriceNew;
            do
            {
                answer[0]++;
                if (answer[0] % 2 == 0) percentLossByMonth += 0.5;
                startPriceOldDouble = (startPriceOldDouble - (startPriceOldDouble * percentLossByMonth * 0.01));
                startPriceNewDouble = (startPriceNewDouble - (startPriceNewDouble * percentLossByMonth * 0.01));
                savedMoney += savingPerMonth;
            } while (startPriceNewDouble - startPriceOldDouble - savedMoney > 0);
            answer[1] = (int) Math.Round((savedMoney + startPriceOldDouble) - startPriceNewDouble);
            return answer;
        }
    }
}