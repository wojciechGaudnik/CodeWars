using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6FruitMachine
    {
        public static void Main(string[] args)
        {
            kyu6FruitMachine kata = new kyu6FruitMachine();
            string[] reel1 = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            string[] reel2 = new string[] { "Bar", "Wild", "Queen", "Bell", "King", "Seven", "Cherry", "Jack", "Star", "Shell" };
            string[] reel3 = new string[] { "Bell", "King", "Wild", "Bar", "Seven", "Jack", "Shell", "Cherry", "Queen", "Star" };
            List<string[]> reels = new List<string[]> { reel1, reel2, reel3 };
            int[] spins = new int[] { 5, 4, 3 };
            Console.WriteLine(kata.fruit(reels, spins));
        }

        public int fruit(List<string[]> reels, int[] spins)
        {
            var scoring = new List<string>{"Jack", "Queen", "King", "Bar", "Cherry", "Seven", "Shell", "Bell", "Star", "Wild"};
            var cards = new List<string> {reels[0][spins[0]], reels[1][spins[1]], reels[2][spins[2]]};
            cards.Sort();
            var cardsSet = cards.ToHashSet();
            if (cardsSet.Count == 1) return (scoring.IndexOf(cardsSet.First()) + 1) * 10;
            if (cardsSet.Count != 2) return 0;
            var doublet = cardsSet.Where(cS => cards.Count(cL => cL.Equals(cS)) == 2).ToArray()[0];
            if (!cards.Contains(scoring[9])) return scoring.IndexOf(doublet) + 1;
            if (cards.Contains(scoring[9])) return (scoring.IndexOf(doublet) + 1) * 2;
            return 0;
        }

    }
}