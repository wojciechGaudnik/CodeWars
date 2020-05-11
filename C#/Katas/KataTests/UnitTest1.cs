using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("st", kyu6OrdinalNumbers.Ordinal(1));
            Assert.AreEqual("th", kyu6OrdinalNumbers.Ordinal(11));
            Assert.AreEqual("th", kyu6OrdinalNumbers.Ordinal(111));
            Assert.AreEqual("st", kyu6OrdinalNumbers.Ordinal(121));
            Assert.AreEqual("th", kyu6OrdinalNumbers.Ordinal(20));
            Assert.AreEqual("nd", kyu6OrdinalNumbers.Ordinal(52));
            Assert.AreEqual("d", kyu6OrdinalNumbers.Ordinal(903, true));
        }
    }
}