using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public class CarboatTests {

    [Test]
    public static void BasicTest() {
        Assert.AreEqual("[[M: 37 B: 5 C: 4][M: 100 B: 14 C: 11]]", kyu6HowMuch.howmuch(1, 100));
        Assert.AreEqual("[]", kyu6HowMuch.howmuch(2950, 2950));
    }

}