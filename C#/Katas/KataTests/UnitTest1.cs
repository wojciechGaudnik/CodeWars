using NUnit.Framework;
using System;
using Katas;

public class ExampleTests
{
    [Test]
    public void TestBob27Male()
    {
        var dm = new kyu6FIXMEHello().SetName("Bob").SetAge(27).SetSex('M');
        var expected = "Hello. My name is Bob. I am 27. I am male.";
        Assert.AreEqual(expected, dm.Hello());
    }

    [Test]
    public void Test27MaleBob()
    {
        var dm = new kyu6FIXMEHello().SetAge(27).SetSex('M').SetName("Bob");
        var expected = "Hello. I am 27. I am male. My name is Bob.";
        Assert.AreEqual(expected, dm.Hello());
    }

    [Test]
    public void TestAliceFemale()
    {
        var dm = new kyu6FIXMEHello().SetName("Alice").SetSex('F');
        var expected = "Hello. My name is Alice. I am female.";
        Assert.AreEqual(expected, dm.Hello());
    }

    [Test]
    public void TestBatman()
    {
        var dm = new kyu6FIXMEHello().SetName("Batman");
        var expected = "Hello. My name is Batman.";
        Assert.AreEqual(expected, dm.Hello());
    }
}