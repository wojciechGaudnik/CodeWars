using NUnit.Framework;
using System.Collections.Generic;
using Katas;

namespace CodeWars
{
    [TestFixture]
    class KataTestClass
    {
        [TestCase]
        public void BasicTest1()
        {
            kyu6FruitMachine kata = new kyu6FruitMachine();
            string[] reel = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel, reel, reel };
            int[] spins = new int[] { 0, 0, 0 };
            Assert.AreEqual(100, kata.fruit( reels, spins));
        }

        [TestCase]
        public void BasicTest2()
        {
            kyu6FruitMachine kata = new kyu6FruitMachine();
            string[] reel1 = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            string[] reel2 = new string[] { "Bar", "Wild", "Queen", "Bell", "King", "Seven", "Cherry", "Jack", "Star", "Shell" };
            string[] reel3 = new string[] { "Bell", "King", "Wild", "Bar", "Seven", "Jack", "Shell", "Cherry", "Queen", "Star" };
            List<string[]> reels = new List<string[]> { reel1, reel2, reel3 };
            int[] spins = new int[] { 5, 4, 3 };
            Assert.AreEqual(0, kata.fruit(reels, spins));
        }

        [TestCase]
        public void BasicTest3()
        {
            kyu6FruitMachine kata = new kyu6FruitMachine();
            string[] reel1 = new string[] { "King", "Cherry", "Bar", "Jack", "Seven", "Queen", "Star", "Shell", "Bell", "Wild" };
            string[] reel2 = new string[] { "Bell", "Seven", "Jack", "Queen", "Bar", "Star", "Shell", "Wild", "Cherry", "King" };
            string[] reel3 = new string[] { "Wild", "King", "Queen", "Seven", "Star", "Bar", "Shell", "Cherry", "Jack", "Bell" };
            List<string[]> reels = new List<string[]> { reel1, reel2, reel3 };
            int[] spins = new int[] { 0, 0, 1 };
            Assert.AreEqual(3, kata.fruit(reels, spins));
        }

        [TestCase]
        public void BasicTest4()
        {
            kyu6FruitMachine kata = new kyu6FruitMachine();
            string[] reel1 = new string[] { "King", "Jack", "Wild", "Bell", "Star", "Seven", "Queen", "Cherry", "Shell", "Bar" };
            string[] reel2 = new string[] { "Star", "Bar", "Jack", "Seven", "Queen", "Wild", "King", "Bell", "Cherry", "Shell" };
            string[] reel3 = new string[] { "King", "Bell", "Jack", "Shell", "Star", "Cherry", "Queen", "Bar", "Wild", "Seven" };
            List<string[]> reels = new List<string[]> { reel1, reel2, reel3 };
            int[] spins = new int[] { 0, 5, 0 };
            Assert.AreEqual(6, kata.fruit(reels, spins));
        }
    }
}