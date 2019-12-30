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
            Assert.AreEqual("1", LargeFactorials.Factorial(1));
            Assert.AreEqual("120", LargeFactorials.Factorial(5));
            Assert.AreEqual("362880", LargeFactorials.Factorial(9));
            Assert.AreEqual("1307674368000", LargeFactorials.Factorial(15));
        }
    }
}