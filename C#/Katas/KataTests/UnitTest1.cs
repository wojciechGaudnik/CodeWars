using NUnit.Framework;
using System;
using Katas;

[TestFixture]
public class StairsTests
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(6, kyu6VasyaAndStairs.NumberOfSteps(10, 2));
    }

    [Test]
    public void Test2()
    {
        Assert.AreEqual(-1, kyu6VasyaAndStairs.NumberOfSteps(3, 5));
    }

    [Test]
    public void Test3()
    {
        Assert.AreEqual(10, kyu6VasyaAndStairs.NumberOfSteps(18, 10));
        Assert.AreEqual(20, kyu6VasyaAndStairs.NumberOfSteps(21, 10));
        Assert.AreEqual(2, kyu6VasyaAndStairs.NumberOfSteps(2, 2));
    }
}