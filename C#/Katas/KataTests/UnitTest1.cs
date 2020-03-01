using Katas;

namespace Solution {
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SampleTests {
        [Test]
        public void TestCases()
        {
            var _ = new kyu6ValidateCreditCardNumber();
            Assert.AreEqual(false,_.validate("477 073 360"));
            Assert.AreEqual(true,_.validate("5422 0148 5514"));
            Assert.AreEqual(true,_.validate("8314 7046 0245"));
            Assert.AreEqual(false,_.validate("6654 6310 43044"));
            Assert.AreEqual(true,_.validate("0768 2757 5685 6340"));
            Assert.AreEqual(false,_.validate("7164 6207 74042"));
            Assert.AreEqual(true,_.validate("8383 7332 3570 8514"));
            Assert.AreEqual(true,_.validate("481 135"));
            Assert.AreEqual(true,_.validate("355 032 5363"));
        }
    }
}