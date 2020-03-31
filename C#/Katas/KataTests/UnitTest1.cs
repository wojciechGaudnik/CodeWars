using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public static class BankerPlanTests {

    private static void testing(Boolean actual, Boolean expected) {
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public static void test1() {
        Console.WriteLine("Testing Fortune");
        testing(kyu6BankersPlan.Fortune(100000, 1, 2000, 15, 1), true);
        testing(kyu6BankersPlan.Fortune(100000, 1, 9185, 12, 1), false);
        testing(kyu6BankersPlan.Fortune(100000000, 1, 100000, 50, 1), true);
        testing(kyu6BankersPlan.Fortune(100000000, 1.5, 10000000, 50, 1), false);
        testing(kyu6BankersPlan.Fortune(100000000, 5, 1000000, 50, 1), true);
        testing(kyu6BankersPlan.Fortune(10000, 0, 10000, 2, 0), true);
        testing(kyu6BankersPlan.Fortune(13805854, 1, 921044, 15, 2), true);
        testing(kyu6BankersPlan.Fortune(9999, 61.8161, 10000, 3, 0), false);
    }
}