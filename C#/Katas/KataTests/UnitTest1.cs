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
                yield return new TestCaseData(new Node1(10, new Node1(1), new Node1(2))).Returns(13).SetDescription("Simple Test");
                yield return new TestCaseData(new Node1(11, new Node1(0), new Node1(0, null, new Node1(1)))).Returns(12).SetDescription("Handles unbalanced trees");
            }
        }

        [Test, TestCaseSource("testCases")]
        public int Test(Node1 root) =>
            kyu6SumTheTree.SumTree(root);
    }
}