using Katas;

namespace Solution {
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class Test
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual("four", kyu6StringAverage.AverageString("zero nine five two"));
            Assert.AreEqual("three", kyu6StringAverage.AverageString("four six two three"));
            Assert.AreEqual("three", kyu6StringAverage.AverageString("one two three four five"));
            Assert.AreEqual("four", kyu6StringAverage.AverageString("five four"));
            Assert.AreEqual("zero", kyu6StringAverage.AverageString("zero zero zero zero zero"));
            Assert.AreEqual("two", kyu6StringAverage.AverageString("one one eight one"));
            Assert.AreEqual("n/a", kyu6StringAverage.AverageString(""));
        }
    }
}