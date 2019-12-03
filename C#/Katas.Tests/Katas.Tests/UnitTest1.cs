using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public static class SumFractionsTests
{
    private static void testing(string actual, string expected)
    {
        Assert.AreEqual(expected, actual);
    }
    [Test]
    public static void test()
    {
        Console.WriteLine("Fixed Tests");
        int[,] a = new int[,] { {1,2}, {2,9}, {3,18}, {4,24}, {6,48} };
        String r = "[85, 72]";
        testing(SumFractions.SumFracts(a), r);
        a = new int[,] { {1, 2}, {1, 3}, {1, 4} };
        r = "[13, 12]";
        testing(SumFractions.SumFracts(a), r);
        a = new int[,] { {1, 3}, {5, 3} };
        r = "2";
        testing(SumFractions.SumFracts(a), r);
        a = new int[,] {};
        r = null;
    }
}