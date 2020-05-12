using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public static class PentanacciTests {

    private static void testing(long actual, long expected) {
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public static void test1() {
        Console.WriteLine("Fixed Tests: CountOddPentaFib, low values");
        long[] lstI = new long[] {45, 68, 76, 100, 121};
        long[] resultsI = new long[] {15, 23, 25, 33, 40};
        for (int i = 0; i <= 4; i++) {
            testing(kyu6Pentabonscci.CountOddPentaFib(lstI[i]), resultsI[i]);
        }
    }
}