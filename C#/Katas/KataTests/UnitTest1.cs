using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTest()
        {
            var arr = new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12 };
            Assert.AreEqual(12, kyu6HighestRankNumberInAnArray.HighestRank(arr));
        }
    }
}