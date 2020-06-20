namespace Solution
{
    using NUnit.Framework;
    using KatasNewNode;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(
                new Node(3, new Node(2, new Node(1, null))),
                kyu6ReverseASinglyLinkedList.ReverseList(new Node(1, new Node(2, new Node(3, null)))));

            // For simplicity, Node can also be constructed using any non-empty IEnumerable<int>:
            Assert.AreEqual(
                new Node(new int[] {5, 4, 3, 2, 1}),
                kyu6ReverseASinglyLinkedList.ReverseList(new Node(new int[] {1, 2, 3, 4, 5})));
        }
    }
}