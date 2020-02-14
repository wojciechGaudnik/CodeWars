using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(true, kyu6Detect_Pangram.IsPangram("The quick brown fox jumps over the lazy dog."));
        }
    }
}