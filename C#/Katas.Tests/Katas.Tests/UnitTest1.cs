using Katas;
using NUnit.Framework;

[TestFixture]
public class NumberTest
{
    private SumofDigitsDigitalRoot num;

    [SetUp]
    public void SetUp()
    {
        num = new SumofDigitsDigitalRoot();
    }

    [TearDown]
    public void TearDown()
    {
        num = null;
    }

    [Test]
    public void Tests()
    {
        Assert.AreEqual(7, num.DigitalRoot(16));
        Assert.AreEqual(6, num.DigitalRoot(456));
    }
}