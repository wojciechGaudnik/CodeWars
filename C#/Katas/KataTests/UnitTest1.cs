using NUnit.Framework;
using System;
using Katas;

[TestFixture]
public class ListTests
{
    [Test]
    public void When03_Then6()
    {
        Assert.AreEqual(6,kyu6TwistedSum.Solution(3));
    }
    [Test]
    public void When10_Then46()
    {
        Assert.AreEqual(46,kyu6TwistedSum.Solution(10));
    }
    [Test]
    public void When11_Then48()
    {
        Assert.AreEqual(48,kyu6TwistedSum.Solution(11));
    }
    [Test]
    public void When12_Then51()
    {
        Assert.AreEqual(51,kyu6TwistedSum.Solution(12));
    }
}
