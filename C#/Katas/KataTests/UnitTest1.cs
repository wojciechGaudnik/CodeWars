using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public static class CycleTests
{
    private static void dotest(int n, int expected) {
        Console.WriteLine("n: {0}, expected: {1}", n, expected);
        Assert.AreEqual(expected, kyu61nCycle.Running(n));
    }
    [Test]
    public static void fixedtest()
    {
        Console.WriteLine("Fixed Tests");
        dotest(33, 2);
        dotest(18118, -1);
        dotest(69, 22);
        dotest(197, 98);
        dotest(65, -1);
    }
}