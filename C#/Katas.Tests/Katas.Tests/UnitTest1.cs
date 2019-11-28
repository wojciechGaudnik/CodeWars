using Katas;

namespace Solution {
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Smell my cheese you mother!", AlanPartridgeIII_London.Alan(new string[] {"Norwich", "Rejection", "Disappointment", "Backstabbing Central", "Shattered Dreams Parkway", "London"}));
            Assert.AreEqual("No, seriously, run. You will miss it.", AlanPartridgeIII_London.Alan(new string[] {"London", "Norwich"}));
            Assert.AreEqual("Smell my cheese you mother!", AlanPartridgeIII_London.Alan(new string[] {"Norwich", "Tooting", "Bank", "Rejection", "Disappointment", "Backstabbing Central", "Exeter", "Shattered Dreams Parkway", "Belgium","London"}));
        }
    }
}