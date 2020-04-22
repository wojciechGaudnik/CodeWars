using Katas;

namespace Solution {
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest {
        [Test]
        public void BasicTests() {
            Assert.IsTrue(kyu6SchrödingersBoolean.omnibool == true);
            Assert.IsTrue(kyu6SchrödingersBoolean.omnibool == false);
        }
    }
}