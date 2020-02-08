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
                yield return new TestCaseData(1)
                    .Returns(true)
                    .SetDescription("1 is narcissitic");
                yield return new TestCaseData(371)
                    .Returns(true)
                    .SetDescription("371 is narcissitic");

            }
        }

        [Test, TestCaseSource("testCases")]
        public bool Test(int n) => DoesMyNumberLookBigInThisKyu6.Narcissistic(n);
    }
}