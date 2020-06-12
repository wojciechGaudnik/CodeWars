using Katas;

namespace Solution {
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class StrongestEvenNumberTest
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(2, kyu6StrongestEvenNumerInAnInterval.strongestEven(1,2));
            Assert.AreEqual(8, kyu6StrongestEvenNumerInAnInterval.strongestEven(5,10));
            Assert.AreEqual(48, kyu6StrongestEvenNumerInAnInterval.strongestEven(48,56));
            Assert.AreEqual(192, kyu6StrongestEvenNumerInAnInterval.strongestEven(129,193));
            Assert.AreEqual(1073741824, kyu6StrongestEvenNumerInAnInterval.strongestEven(689930869,2079841036));
        }

        [Test] public void SampleTests2()
        {
            Assert.AreEqual(2, kyu6StrongestEvenNumerInAnInterval.strongestEven(2,3));
            Assert.AreEqual(2, kyu6StrongestEvenNumerInAnInterval.strongestEven(1,2));
            Assert.AreEqual(1879048192, kyu6StrongestEvenNumerInAnInterval.strongestEven(1842115325,1885740044));
            Assert.AreEqual(2130706432, kyu6StrongestEvenNumerInAnInterval.strongestEven(2117124929,2140281807));
        }

        [Test] public void SampleTests3()
        {
            Assert.AreEqual(256, kyu6StrongestEvenNumerInAnInterval.strongestEven(3,310));
            Assert.AreEqual(1073741824, kyu6StrongestEvenNumerInAnInterval.strongestEven(77256062,1690795259));
        }
    }
}