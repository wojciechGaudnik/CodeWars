using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(kyu6BasicEncryption.Encrypt("", 1), Is.EqualTo(""));
            Assert.That(kyu6BasicEncryption.Encrypt("a", 1), Is.EqualTo("b"));
            Assert.That(kyu6BasicEncryption.Encrypt("please encrypt me", 2), Is.EqualTo("rngcug\"gpet{rv\"og"));
        }
    }
}