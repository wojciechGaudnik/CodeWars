using NUnit.Framework;
using System;
using Katas;

class ExampleTest
{
    [Test]
    public void FixedTest()
    {
        Assert.AreEqual("546 52532 89", kyu6GenericNumericTemplateFormatter.NumericFormatter("xxx xxxxx xx", "5465253289"));
        Assert.AreEqual("123 45678 90", kyu6GenericNumericTemplateFormatter.NumericFormatter("xxx xxxxx xx"));
        Assert.AreEqual("+555 1803 1978", kyu6GenericNumericTemplateFormatter.NumericFormatter("+555 aaaa bbbb", "18031978"));
        Assert.AreEqual("+555 1234 5678", kyu6GenericNumericTemplateFormatter.NumericFormatter("+555 aaaa bbbb"));
        Assert.AreEqual("1234 5678 9012", kyu6GenericNumericTemplateFormatter.NumericFormatter("xxxx yyyy zzzz"));
        Assert.AreEqual("8+643 295584642 ", kyu6GenericNumericTemplateFormatter.NumericFormatter("F+oB3 IWM5V4Qgk ", "864295"));
    }
}