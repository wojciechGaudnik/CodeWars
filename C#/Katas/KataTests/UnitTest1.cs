using Katas;

namespace Learning {
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class CypherTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("66542", kyu6MrSafetysTreasures.Unlock("Nokia") );
            Assert.AreEqual("82588", kyu6MrSafetysTreasures.Unlock("Valut"));
            Assert.AreEqual("864538", kyu6MrSafetysTreasures.Unlock("toilet"));
        }
    }
}
