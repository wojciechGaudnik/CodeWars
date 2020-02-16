using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(kyu6WriteNumberInExpandedForm.ExpandedForm(12), Is.EqualTo("10 + 2"));
            Assert.That(kyu6WriteNumberInExpandedForm.ExpandedForm(42), Is.EqualTo("40 + 2"));
            Assert.That(kyu6WriteNumberInExpandedForm.ExpandedForm(70304), Is.EqualTo("70000 + 300 + 4"));
        }
    }
}