using NUnit.Framework;
using System;
using Katas;

namespace Solution
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SimpleTests()
        {
            Assert.AreEqual(0, kyu6ShortestStepsToANumber.ShortestStepsToNum(1));
            Assert.AreEqual(4, kyu6ShortestStepsToANumber.ShortestStepsToNum(12));
            Assert.AreEqual(4, kyu6ShortestStepsToANumber.ShortestStepsToNum(16));
            Assert.AreEqual(9, kyu6ShortestStepsToANumber.ShortestStepsToNum(71));
        }
    }
}