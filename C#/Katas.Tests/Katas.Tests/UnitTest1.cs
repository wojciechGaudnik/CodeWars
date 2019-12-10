using System;
using NUnit.Framework;
using Katas;

[TestFixture]
public class FactorialTests
{
    [Test]
    public void When0ToDollarsReturnsDollar0_00()
    {
        Assert.AreEqual("$0.00", (0m).ToCurrency("$"));
    }

    [Test]
    public void When1_23ToDollarsReturnsDollar1_23()
    {
        Assert.AreEqual("$1.23", (1.23m).ToCurrency("$"));
    }

    [Test]
    public void When99_9999ToDollarsReturnsDollar100_00()
    {
        Assert.AreEqual("$100.00", (99.9999m).ToCurrency("$"));
    }

    [Test]
    public void WhenNegative12345_6789ToDollarsReturnsMinusDollar12345__68()
    {
        Assert.AreEqual("-$12345.68", (-12345.6789m).ToCurrency("$"));
    }

    [Test]
    public void When12345_6789ToPoundsReturnsPound12345__68()
    {
        Assert.AreEqual("£12345.68", (12345.6789m).ToCurrency("£"));
    }
}