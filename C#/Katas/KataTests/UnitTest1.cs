using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    public static void FixedTest()
    {
        Assert.AreEqual(new int[]{118, 334}, HowManyNumbers3.FindAll(10, 3));
        Assert.AreEqual(new int[]{999, 999}, HowManyNumbers3.FindAll(27, 3));
        Assert.AreEqual(new int[]{116999, 566666}, HowManyNumbers3.FindAll(35, 6));
    }
}