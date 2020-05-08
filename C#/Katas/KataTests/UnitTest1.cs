using Katas;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(100000, ExpectedResult="100,000")]
    [TestCase(5678545, ExpectedResult="5,678,545")]
    public static string FixedTest(int num)
    {
        return kyu6NumberFormat.NumberFormat(num);
    }
}