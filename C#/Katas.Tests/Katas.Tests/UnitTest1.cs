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
            Assert.AreEqual(3, CountTheDivisibleNumbers.DivisibleCount(6, 11, 2));
        }
    }
}