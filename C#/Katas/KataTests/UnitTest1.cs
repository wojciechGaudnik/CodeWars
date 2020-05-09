using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(0, kyu6DeadAnts.DeadAntCount("ant ant ant ant"));
            Assert.AreEqual(0, kyu6DeadAnts.DeadAntCount(null));
            Assert.AreEqual(2, kyu6DeadAnts.DeadAntCount("ant anantt aantnt"));
            Assert.AreEqual(1, kyu6DeadAnts.DeadAntCount("ant ant .... a nt"));
        }
    }
}