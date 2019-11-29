using System;
using System.Linq;

namespace Katas
{
    public class AlanPartridgeIII_London
    {
        public static string Alan(string[] x)
        {
            string[] stations = {"Rejection", "Disappointment", "Backstabbing Central", "Shattered Dreams Parkway"};
            return (!stations.Except(x).Any())?"Smell my cheese you mother!":"No, seriously, run. You will miss it.";
        }
    }
}