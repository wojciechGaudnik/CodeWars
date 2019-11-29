using System;
using System.Text.RegularExpressions;
using Katas;
using NUnit.Framework;

public class Tests
{
    [Test]
    [TestCase("123", ExpectedResult=true)]
    [TestCase("248", ExpectedResult=true)]
    [TestCase("8", ExpectedResult=false)]
    [TestCase("321", ExpectedResult=true)]
    [TestCase("9453", ExpectedResult=false)]
    public static bool FixedTest(string code)
    {
        return validateCodeWithSimpleRegex.ValidateCode(code);
    }
}