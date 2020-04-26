using Katas;

namespace Solution {
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {

        [Test]
        public void SampleTest1()
        {
            Assert.AreEqual(10, kyu6IntegerDepth.ComputeDepth(1));
        }

        [Test]
        public void SampleTest2()
        {
            Assert.AreEqual(9, kyu6IntegerDepth.ComputeDepth(42));
        }

    }
}