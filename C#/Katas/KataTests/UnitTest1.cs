using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SplitStringTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new string[] { "ab", "c_" }, kyu6SplitStrings.Solution("abc"));
            Assert.AreEqual(new string[] { "ab", "cd", "ef" }, kyu6SplitStrings.Solution("abcdef"));
        }
    }
}