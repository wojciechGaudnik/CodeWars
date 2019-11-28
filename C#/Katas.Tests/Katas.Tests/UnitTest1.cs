using Katas;
using NUnit.Framework;

namespace Solution {
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual("Mine's a Pint!", AlanPartridgeIPartridgeWatch.Part(new String[] {"Grouse", "Partridge", "Pheasant"}));
            Assert.AreEqual("Mine's a Pint!!!!!!!!", AlanPartridgeIPartridgeWatch.Part(new String[] {"Grouse", "Partridge", "Pheasant", "Goose", "Starling", "Robin", "Thrush", "Emu", "PearTree", "Chat", "Dan", "Square", "Toblerone", "Lynn", "AlphaPapa", "BMW", "Graham", "Tool", "Nomad", "Finger", "Hamster"}));
            Assert.AreEqual("Lynn, I've pierced my foot on a spike!!", AlanPartridgeIPartridgeWatch.Part(new string[] {"Pheasant", "Goose", "Starling", "Robin"}));
        }
    }
}