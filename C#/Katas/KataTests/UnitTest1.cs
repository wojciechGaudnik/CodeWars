using Katas;

namespace Solution {
    using NUnit.Framework;
    using System;
    
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(12,kyu6SumOfaSequenceHardCoreVersion.SequenceSum(2, 6, 2));
            Assert.AreEqual(15,kyu6SumOfaSequenceHardCoreVersion.SequenceSum(1, 5, 1));
            Assert.AreEqual(5,kyu6SumOfaSequenceHardCoreVersion.SequenceSum(1, 5, 3));
            Assert.AreEqual(0,kyu6SumOfaSequenceHardCoreVersion.SequenceSum(16, 15, 3));
            Assert.AreEqual(-26,kyu6SumOfaSequenceHardCoreVersion.SequenceSum(-24, -2, 22));
            Assert.AreEqual(-2,kyu6SumOfaSequenceHardCoreVersion.SequenceSum(-2, 4, 658));
            Assert.AreEqual(469436517521190,kyu6SumOfaSequenceHardCoreVersion.SequenceSum(780, 68515438, 5));
            Assert.AreEqual(-5,kyu6SumOfaSequenceHardCoreVersion.SequenceSum(-1, -5, -3));
            Assert.AreEqual(-5,kyu6SumOfaSequenceHardCoreVersion.SequenceSum(-1, -5, -3));
        }
    }
}