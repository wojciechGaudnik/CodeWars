using Katas;

namespace Solution {
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ExampleTests
    {
        [Test]
        public void LongestAtTheBeginning()
        {
            Assert.AreEqual(new Tuple<char?, int> ('a', 4), kyu6CharacterWithLongestConsecutiveRepetition.LongestRepetition("aaaabb"));
            Assert.AreEqual(new Tuple<char?, int> ('b', 5), kyu6CharacterWithLongestConsecutiveRepetition.LongestRepetition("abbbbb"));
        }

        [Test]
        public void LongestAtTheEnd()
        {
            Assert.AreEqual(new Tuple<char?, int> ('a', 4), kyu6CharacterWithLongestConsecutiveRepetition.LongestRepetition("bbbaaabaaaa"));
        }

        [Test]
        public void LongestInTheMiddle()
        {
            Assert.AreEqual(new Tuple<char?, int> ('u', 3), kyu6CharacterWithLongestConsecutiveRepetition.LongestRepetition("cbdeuuu900"));
        }

        [Test]
        public void MultipleLongest()
        {
            Assert.AreEqual(new Tuple<char?, int> ('a', 2), kyu6CharacterWithLongestConsecutiveRepetition.LongestRepetition("aabb"));
            Assert.AreEqual(new Tuple<char?, int> ('b', 1), kyu6CharacterWithLongestConsecutiveRepetition.LongestRepetition("ba"));
        }

        [Test]
        public void EmptyString()
        {
            Assert.AreEqual(new Tuple<char?, int> (null, 0),  kyu6CharacterWithLongestConsecutiveRepetition.LongestRepetition(""));
        }
    }
}