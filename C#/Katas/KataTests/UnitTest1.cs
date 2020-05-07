using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class NumberPyramidTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("", kyu6CompleteThePattern8NumberPyramid.Pattern(0));
            Assert.AreEqual("", kyu6CompleteThePattern8NumberPyramid.Pattern(-25));
            Assert.AreEqual("1", kyu6CompleteThePattern8NumberPyramid.Pattern(1));
            Assert.AreEqual("   1   \n  121  \n 12321 \n1234321", kyu6CompleteThePattern8NumberPyramid.Pattern(4));
            Assert.AreEqual("      1      \n     121     \n    12321    \n   1234321   \n  123454321  \n 12345654321 \n1234567654321", kyu6CompleteThePattern8NumberPyramid.Pattern(7));
        }
    }
}