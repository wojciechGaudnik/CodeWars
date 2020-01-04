using Katas;
using NUnit.Framework;
public class SolutionTest
{
    [Test]
    public void FixedTests()
    {
        Assert.AreEqual(1, parseInReloaded.ParseInt("one"));
        Assert.AreEqual(20, parseInReloaded.ParseInt("twenty"));
        Assert.AreEqual(246, parseInReloaded.ParseInt("two hundred forty-six"));
    }
}