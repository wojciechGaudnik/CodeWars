using Katas;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [TestCase("", 0)]
        [TestCase("hello", 8)]
        [TestCase("bacon(d)", 18)]
        [TestCase("pizza(t)", 75)]
        [TestCase("pupp**ie*s", 70)]
        [TestCase("task^", 3)]
        public void ExampleTests(string word, int expectedScore)
        {
            Assert.AreEqual(expectedScore, ScrabbleWordCalculator.CalculateScrabbleWord(word));
        }
    }
}