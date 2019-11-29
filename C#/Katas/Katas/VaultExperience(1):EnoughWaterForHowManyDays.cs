using System;

namespace Katas
{
    public class VaultExperience_1__EnoughWaterForHowManyDays
    {
        public static int ThirstyIn(int water, int[] ageOfDweller)
        {
            if (ageOfDweller.Length == 0) return -1;
            int dwellerUnder18 = Array.FindAll(ageOfDweller,d => d < 18).Length;
            int dwellerAbove50 = Array.FindAll(ageOfDweller,d => d > 50).Length;
            int dwellerRest = ageOfDweller.Length - dwellerUnder18 - dwellerAbove50;
            double daily = dwellerUnder18 + dwellerAbove50 * 1.5 + dwellerRest * 2;
            return (int) (water / daily);
        }

    }
}