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
            Assert.AreEqual(2, kyu6SqrtApproximation.SqrtApproximation(4), "Should work for integer roots.");
            Assert.AreEqual(new int[] { 2,3 }, kyu6SqrtApproximation.SqrtApproximation(5), "Should work for range approximation.");
        }
    }
}