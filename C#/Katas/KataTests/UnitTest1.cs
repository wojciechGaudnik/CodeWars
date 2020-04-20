using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public static class ArcParabLenTests {

    [Test]
    public static void test1()
    {
        Console.WriteLine("Basic Tests");
        Assert.AreEqual(1.414213562, kyu6ParabolicArcLength.lenCurve(1));
        Assert.AreEqual(1.478197397, kyu6ParabolicArcLength.lenCurve(10));
    }
}