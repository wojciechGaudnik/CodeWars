using Katas;
using NUnit.Framework;

[TestFixture]
public class GroupsTests
{
    [TestCase("()", true)]
    [TestCase("({", false)]
    public void Tests(string input, bool expected)
    {
        Assert.AreEqual(expected, kyu6CheckingGroups.Check(input));
    }
}