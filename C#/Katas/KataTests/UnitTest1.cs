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
                yield return new TestCaseData(new int[,] {{1, 0}, {0, 0}}).Returns(new Tuple<int, int>(0, 0));
                yield return new TestCaseData(new int[,] {{1, 0, 0}, {0, 0, 0}, {0, 0, 0}}).Returns(new Tuple<int, int>(0, 0));
                yield return new TestCaseData(new int[,] {{0, 0, 0, 0}, {0, 0, 0, 0}, {0, 0, 1, 0}, {0, 0, 0, 0}}).Returns(new Tuple<int, int>(2, 2));
            }
        }

        [Test, TestCaseSource("testCases")]
        public Tuple<int, int> Test(int[,] field) => kyu6FindTheMine.MineLocation(field);
    }
}