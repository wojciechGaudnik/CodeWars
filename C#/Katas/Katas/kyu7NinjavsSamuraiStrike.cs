using System;

namespace Katas
{
    public class kyu7NinjavsSamuraiStrike
    {
        private string name;

        public kyu7NinjavsSamuraiStrike(string name)
        {
            this.name = name;
        }

        public int Health { get; private set; } = 100;

        public void Strike(kyu7NinjavsSamuraiStrike enemy, int swings)
        {
            enemy.Health = Math.Max(0, enemy.Health - (swings * 10));
        }
    }
}