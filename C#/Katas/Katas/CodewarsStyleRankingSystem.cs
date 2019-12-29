using System;
using System.Collections.Generic;
using System.Text;

namespace Katas
{
    public class CodewarsStyleRankingSystem
    {

        public class User
        {
            public int rank;
            public int progress;
            private readonly Dictionary<int, int> _rankDictionary = new Dictionary<int, int>();

            public User()
            {
                rank = -8;
                progress = 0;
                _rankDictionary.Add(-8, -8);
                _rankDictionary.Add(-7, -7);
                _rankDictionary.Add(-6, -6);
                _rankDictionary.Add(-5, -5);
                _rankDictionary.Add(-4, -4);
                _rankDictionary.Add(-3, -3);
                _rankDictionary.Add(-2, -2);
                _rankDictionary.Add(-1, -1);
                _rankDictionary.Add(1, 0);
                _rankDictionary.Add(2, 1);
                _rankDictionary.Add(3, 2);
                _rankDictionary.Add(4, 3);
                _rankDictionary.Add(5, 4);
                _rankDictionary.Add(6, 5);
                _rankDictionary.Add(7, 6);
                _rankDictionary.Add(8, 7);
            }

            public void incProgress(int rank)
            {
                if (rank < -8 || rank == 0 || rank > 8)
                    throw new ArgumentException(String.Format($"Unknown rank: {rank}"));
                if (this.rank == 8) return;

                var difference = _rankDictionary[rank] - _rankDictionary[this.rank];

                if (difference == 0) progress += 3;
                else if (difference == -1) progress += 1;
                else if (difference > 0) progress += 10 * difference * difference;

                if (progress < 100) return;
                var ranksUp = progress / 100;
                var rest = progress % 100;
                for (var i = 0; i < ranksUp; i++)
                {
                    this.rank++;
                    if (this.rank == 0) this.rank++;
                    if (this.rank == 8)
                    {
                        progress = 0;
                        rest = 0;
                        break;
                    }
                }

                progress = rest;
            }
        }
    }
}












