using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual("Thi1s is2 3a T4est", YourOrderPlease.Order("is2 Thi1s T4est 3a"));
            Assert.AreEqual("Fo1r the2 g3ood 4of th5e pe6ople", YourOrderPlease.Order("4of Fo1r pe6ople g3ood th5e the2"));
            Assert.AreEqual("", YourOrderPlease.Order(""));
        }
    }
}