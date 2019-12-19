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
            Assert.AreEqual(new int[] {2},       Array_diff.ArrayDiff(new int[] {1, 2},    new int[] {1}));
            Assert.AreEqual(new int[] {2, 2},    Array_diff.ArrayDiff(new int[] {1, 2, 2}, new int[] {1}));
            Assert.AreEqual(new int[] {1},       Array_diff.ArrayDiff(new int[] {1, 2, 2}, new int[] {2}));
            Assert.AreEqual(new int[] {1, 2, 2}, Array_diff.ArrayDiff(new int[] {1, 2, 2}, new int[] {}));
            Assert.AreEqual(new int[] {},        Array_diff.ArrayDiff(new int[] {},        new int[] {1, 2}));
        }
    }
}