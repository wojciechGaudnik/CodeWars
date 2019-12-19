using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("(((", DuplicateEncoder.DuplicateEncode("din"));
            Assert.AreEqual("()()()", DuplicateEncoder.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", DuplicateEncoder.DuplicateEncode("Success"), "should ignore case");
            Assert.AreEqual("))((", DuplicateEncoder.DuplicateEncode("(( @"));
            Assert.AreEqual("()(((())())", DuplicateEncoder.DuplicateEncode("CodeWarrior"));
        }
    }
}