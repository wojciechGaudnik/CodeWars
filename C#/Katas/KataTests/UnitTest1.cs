using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    public static void ExampleTests()
    {
        Assert.AreEqual(123, kyu6LucasNumbers.lucasnum(-10));
        Assert.AreEqual(-11, kyu6LucasNumbers.lucasnum(-5));
        Assert.AreEqual(-1, kyu6LucasNumbers.lucasnum(-1));
        Assert.AreEqual(2, kyu6LucasNumbers.lucasnum(0));
        Assert.AreEqual(1, kyu6LucasNumbers.lucasnum(1));
        Assert.AreEqual(11, kyu6LucasNumbers.lucasnum(5));
        Assert.AreEqual(123, kyu6LucasNumbers.lucasnum(10));
    }
}