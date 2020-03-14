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
            Assert.AreEqual("ac", kuy6BackspacesInString.CleanString("abc#d##c"));
            Assert.AreEqual("", kuy6BackspacesInString.CleanString("abc####d##c#"));
        }
    }
}