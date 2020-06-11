using Katas;

namespace Solution {
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("hIJKMNPQRSTUVWXYZeFGIJKMNPQRSTUVWXYZlMNPQRSTUVWXYZloPQRSTUVWXYZ", kyu6MissingAlphabet.InsertMissingLetters("hello"));
        }
    }
}