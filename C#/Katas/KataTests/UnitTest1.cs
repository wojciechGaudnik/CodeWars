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
            Assert.AreEqual(string.Join(",", new [] { "*" }), string.Join(",", kyu6BuildTower.TowerBuilder(1)));
            Assert.AreEqual(string.Join(",", new [] { " * ", "***" }), string.Join(",", kyu6BuildTower.TowerBuilder(2)));
            Assert.AreEqual(string.Join(",", new [] { "  *  ", " *** ", "*****" }), string.Join(",", kyu6BuildTower.TowerBuilder(3)));
        }
    }
}