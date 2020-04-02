using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class GrabscrapTest
    {
        [Test, Description("should pass sample test cases")]
        public void SampleTest()
        {
            Assert.That(kyu6ArrhGrabScrab.Grabscrab("trisf", new List<string> {"first"}), Is.EqualTo(new List<string> {"first"}), "Should have found 'first'");
            Assert.That(kyu6ArrhGrabScrab.Grabscrab("oob", new List<string> {"bob", "baobab"}), Is.EqualTo(new List<string> {}), "Should not have found anything");
            Assert.That(kyu6ArrhGrabScrab.Grabscrab("ainstuomn", new List<string> {"mountains", "hills", "mesa"}), Is.EqualTo(new List<string> {"mountains"}), "Should have found 'mountains'");
            Assert.That(kyu6ArrhGrabScrab.Grabscrab("oolp", new List<string> {"donkey", "pool", "horse", "loop"}), Is.EqualTo(new List<string> {"pool", "loop"}), "Should have found 'pool' and 'loop'");
            Assert.That(kyu6ArrhGrabScrab.Grabscrab("ortsp", new List<string> {"sport", "parrot", "ports", "matey"}), Is.EqualTo(new List<string> {"sport", "ports"}), "Should have found 'sport' and 'ports'");
            Assert.That(kyu6ArrhGrabScrab.Grabscrab("ourf", new List<string> {"one","two","three"}), Is.EqualTo(new List<string> {}), "Should not have found anything");
        }
    }
}