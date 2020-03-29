using Katas;

namespace Solution {
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class Test
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(true, kyu6AreWeAlternate.IsAlt("amazon"));
            Assert.AreEqual(false, kyu6AreWeAlternate.IsAlt("apple"));
            Assert.AreEqual(true, kyu6AreWeAlternate.IsAlt("banana"));
        }
    }
}