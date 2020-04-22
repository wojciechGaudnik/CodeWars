using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class BasicTest
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(11, 5).Returns("00011").SetDescription("ZeroFill succeeds. All hail the Queen!");
                yield return new TestCaseData(11, 11).Returns("00000000011").SetDescription("ZeroFill succeeds. All hail the Queen!");
                yield return new TestCaseData(-32, 5).Returns("00032").SetDescription("ZeroFill succeeds, even with negative number.");
                yield return new TestCaseData(0, 3).Returns("000").SetDescription("ZroFill succeeds, even with zero.");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(int number, int size) =>
            kyu6ZeroFillFor_theQueen.ZeroFill(number, size);
    }
}