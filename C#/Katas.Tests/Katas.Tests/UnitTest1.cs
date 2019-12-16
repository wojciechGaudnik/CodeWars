using NUnit.Framework;
using System;
using Katas;

public class Tests
{
    [Test]
    [TestCase("c", ExpectedResult=false)]
    [TestCase("C", ExpectedResult=true)]
    [TestCase("hello I AM DONALD", ExpectedResult=false)]
    [TestCase("HELLO I AM DONALD", ExpectedResult=true)]
    [TestCase("ACSKLDFJSgSKLDFJSKLDFJ", ExpectedResult=false)]
    [TestCase("ACSKLDFJSGSKLDFJSKLDFJ", ExpectedResult=true)]
    public static bool FixedTest(string text)
    {
        return text.IsUpperCase();
    }
}