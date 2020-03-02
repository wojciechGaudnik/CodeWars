using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class Sample_Test
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(5, 3).Returns(new Tuple<int, int>(3, 5));
                yield return new TestCaseData(4, 6).Returns(new Tuple<int, int>(3, 2));
                yield return new TestCaseData(5, 5).Returns(new Tuple<int, int>(1, 1));
            }
        }

        [Test, TestCaseSource("testCases")]
        public Tuple<int, int> Test(int x, int y) => kyu6TwoJoggers.NbrOfLaps(x, y);
    }
}