using NUnit.Framework;
using System;
using Katas;

class ExampleTest
{
    [Test]
    public void FixedTest()
    {
        Assert.AreEqual(new[] { 1, 2, 3 }, kyu6NSmallestElementsInOriginalOrder.FirstNSmallest(new[] { 1, 2, 3, 4, 5 }, 3));
        Assert.AreEqual(new[] { 3, 2, 1 }, kyu6NSmallestElementsInOriginalOrder.FirstNSmallest(new[] { 5, 4, 3, 2, 1 }, 3));
        Assert.AreEqual(new[] { 1, 2, 1 }, kyu6NSmallestElementsInOriginalOrder.FirstNSmallest(new[] { 1, 2, 3, 1, 2 }, 3));
        Assert.AreEqual(new[] { 1, -4, 0 }, kyu6NSmallestElementsInOriginalOrder.FirstNSmallest(new[] { 1, 2, 3, -4, 0 }, 3));
        Assert.AreEqual(new int[0], kyu6NSmallestElementsInOriginalOrder.FirstNSmallest(new[] { 1, 2, 3, 4, 5 }, 0));
        Assert.AreEqual(new[] { 1, 2, 3, 4, 5 }, kyu6NSmallestElementsInOriginalOrder.FirstNSmallest(new[] { 1, 2, 3, 4, 5 }, 5));
        Assert.AreEqual(new[] { 1, 2, 3, 2 }, kyu6NSmallestElementsInOriginalOrder.FirstNSmallest(new[] { 1, 2, 3, 4, 2 }, 4));
        Assert.AreEqual(new[] { 2, 1 }, kyu6NSmallestElementsInOriginalOrder.FirstNSmallest(new[] { 2, 1, 2, 3, 4, 2 }, 2));
        Assert.AreEqual(new[] { 2, 1, 2 }, kyu6NSmallestElementsInOriginalOrder.FirstNSmallest(new[] { 2, 1, 2, 3, 4, 2 }, 3));
        Assert.AreEqual(new[] { 2, 1, 2, 2 }, kyu6NSmallestElementsInOriginalOrder.FirstNSmallest(new[] { 2, 1, 2, 3, 4, 2 }, 4));
    }
}