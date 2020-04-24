using Katas;

namespace Solution
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test, Description("should be able to handle an empty list.")]
    public void EmptyTest()
    {
      Assert.AreEqual(12, Node.InsertNth(null, 0, 12).Data, "should be able to insert a node on an empty/null list.");
      Assert.AreEqual(null, Node.InsertNth(null, 0, 12).Next, "value at index 1 should be null.");
    }

    [Test, Description("should be able to insert a new node at the head of a list.")]
    public void TestIndex0()
    {
      Assert.AreEqual(23, Node.InsertNth(Node.BuildOneTwoThree(), 0, 23).Data, "should be able to insert new node at head of list.");
      Assert.AreEqual(1, Node.InsertNth(Node.BuildOneTwoThree(), 0, 23).Next.Data, "value for node at index 1 should be 1.");
      Assert.AreEqual(2, Node.InsertNth(Node.BuildOneTwoThree(), 0, 23).Next.Next.Data, "value for node at index 2 should be 2.");
      Assert.AreEqual(3, Node.InsertNth(Node.BuildOneTwoThree(), 0, 23).Next.Next.Next.Data, "value for node at index 3 should be 3.");
      Assert.AreEqual(null, Node.InsertNth(Node.BuildOneTwoThree(), 0, 23).Next.Next.Next.Next, "value at index 4 should be null.");
    }

    [Test, Description("should be able to insert a new node at index 1 of a list.")]
    public void TestIndex1()
    {
      Assert.AreEqual(1, Node.InsertNth(Node.BuildOneTwoThree(), 1, 23).Data, "value for node at index 0 should remain unchanged.");
      Assert.AreEqual(23, Node.InsertNth(Node.BuildOneTwoThree(), 1, 23).Next.Data, "value for node at index 1 should be 23.");
      // Assert.AreEqual(2, Node.InsertNth(Node.BuildOneTwoThree(), 1, 23).Next.Next.Data, "value for node at index 2 should be 2.");
      // Assert.AreEqual(3, Node.InsertNth(Node.BuildOneTwoThree(), 1, 23).Next.Next.Next.Data, "value for node at index 3 should be 3.");
      // Assert.AreEqual(null, Node.InsertNth(Node.BuildOneTwoThree(), 1, 23).Next.Next.Next.Next, "value at index 4 should be null.");
    }

    [Test, Description("should be able to insert a new node at index 2 of a list.")]
    public void TestIndex2()
    {
      Assert.AreEqual(1, Node.InsertNth(Node.BuildOneTwoThree(), 2, 23).Data, "value for node at index 0 should remain unchanged.");
      Assert.AreEqual(2, Node.InsertNth(Node.BuildOneTwoThree(), 2, 23).Next.Data, "value for node at index 1 should remain unchanged.");
      Assert.AreEqual(23, Node.InsertNth(Node.BuildOneTwoThree(), 2, 23).Next.Next.Data, "value for node at index 2 should be 23.");
      Assert.AreEqual(3, Node.InsertNth(Node.BuildOneTwoThree(), 2, 23).Next.Next.Next.Data, "value for node at index 3 should be 3.");
      Assert.AreEqual(null, Node.InsertNth(Node.BuildOneTwoThree(), 2, 23).Next.Next.Next.Next, "value at index 4 should be null.");
    }

    [Test, Description("should be able to insert a new node at the tail of a list.")]
    public void TestIndex3()
    {
      Assert.AreEqual(1, Node.InsertNth(Node.BuildOneTwoThree(), 3, 23).Data, "head should remain unchanged after inserting new node at tail");
      Assert.AreEqual(2, Node.InsertNth(Node.BuildOneTwoThree(), 3, 23).Next.Data, "value at index 1 should remain unchanged after inserting new node at tail");
      Assert.AreEqual(3, Node.InsertNth(Node.BuildOneTwoThree(), 3, 23).Next.Next.Data, "value at index 2 should remain unchanged after inserting new node at tail");
      Assert.AreEqual(23, Node.InsertNth(Node.BuildOneTwoThree(), 3, 23).Next.Next.Next.Data, "value for node at index 3 should be 23.");
      Assert.AreEqual(null, Node.InsertNth(Node.BuildOneTwoThree(), 3, 23).Next.Next.Next.Next, "value at index 4 should be null.");
    }

    [Test, Description("should throw ArgumentOutOfRangeException if index is out of range")]
    public void ExceptionTest()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => Node.InsertNth(Node.BuildOneTwoThree(), 4, 23), "Invalid index value should throw ArugmentException");
      Assert.Throws<ArgumentOutOfRangeException>(() => Node.InsertNth(Node.BuildOneTwoThree(), -4, 23), "Invalid index value should throw ArugmentException");
    }
  }
}