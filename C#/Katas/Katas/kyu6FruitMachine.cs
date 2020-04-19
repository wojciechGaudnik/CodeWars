using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6FruitMachine
    {
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