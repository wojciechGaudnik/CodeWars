using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public class TortoiseTests {

    [Test]
    public void Test1() {
        Console.WriteLine("****** Basic Tests");
        Assert.AreEqual(new int[]{0, 32, 18}, kyu6TortoiseRacing.Race(720, 850, 70));
        Assert.AreEqual(new int[]{3, 21, 49}, kyu6TortoiseRacing.Race(80, 91, 37));
        Assert.AreEqual(new int[]{2, 0, 0}, kyu6TortoiseRacing.Race(80, 100, 40));
    }
}