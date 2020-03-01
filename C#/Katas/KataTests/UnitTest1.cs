using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public class CalcTest
{
    private kyu6ReversePolishNotationCalculator calc = new kyu6ReversePolishNotationCalculator();

    [Test]
    public void ShouldWorkWithEmptyString()
    {
        Assert.AreEqual(0, calc.evaluate(""), 0, "Should work with empty string");
    }

    [Test]
    public void ShouldParseNumbers()
    {
        Assert.AreEqual(3, calc.evaluate("3"), 0, "Should parse numbers");
    }

    [Test]
    public void ShouldParseFloatNumbers()
    {
        Assert.AreEqual(3.5, calc.evaluate("3.5"), 0, "Should parse float numbers");
    }

    [Test]
    public void ShouldSupportAddition()
    {
        Assert.AreEqual(4, calc.evaluate("1 3 +"), 0, "Should support addition");
    }

    [Test]
    public void ShouldSupportMultiplication()
    {
        Assert.AreEqual(3, calc.evaluate("1 3 *"), 0, "Should support multiplication");
    }

    [Test]
    public void ShouldSupportSubstraction()
    {
        Assert.AreEqual(-2, calc.evaluate("1 3 -"), 0, "Should support substraction");
    }

    [Test]
    public void ShouldSupportDivision()
    {
        Assert.AreEqual(2, calc.evaluate("4 2 /"), 0, "Should support division");
    }
}