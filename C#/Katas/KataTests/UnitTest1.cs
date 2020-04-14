using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class KataTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(1, kyu6MutalRecursion.F(0));
            Assert.AreEqual(0, kyu6MutalRecursion.M(0));

            Assert.AreEqual(1, kyu6MutalRecursion.F(1));
            Assert.AreEqual(0, kyu6MutalRecursion.M(1));

            Assert.AreEqual(2, kyu6MutalRecursion.F(2));
            Assert.AreEqual(1, kyu6MutalRecursion.M(2));
        }
    }
}