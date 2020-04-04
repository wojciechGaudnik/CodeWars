using Katas;

namespace Solution {
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        private static object[] sampleTestCases = new object[]
        {
            new object[] {4.2, 4},
            new object[] {4.4, 4.5},
            new object[] {4.6, 4.5},
            new object[] {4.8, 5},
        };

        [Test, TestCaseSource("sampleTestCases")]
        public void SampleTest(double n, double expected)
        {
            Assert.AreEqual(expected, kyu6RoundByHalfSteps.Solution(n));
        }
    }
}