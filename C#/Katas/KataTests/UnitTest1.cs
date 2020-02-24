using System;
using System.Text;
using Katas;
using NUnit.Framework;

[TestFixture]
public class DiamondTest
{

    [Test]
    public void TestNull()
    {
        Assert.IsNull(kyu6GiveMeADiamond.print(0));
        Assert.IsNull(kyu6GiveMeADiamond.print(-2));
        Assert.IsNull(kyu6GiveMeADiamond.print(2));
    }

    [Test]
    public void TestDiamond1()
    {
        var expected = new StringBuilder();
        expected.Append("*\n");
        Assert.AreEqual(expected.ToString(), kyu6GiveMeADiamond.print(1));
    }
    [Test]
    public void TestDiamond3()
    {
        var expected = new StringBuilder();
        expected.Append(" *\n");
        expected.Append("***\n");
        expected.Append(" *\n");

        Assert.AreEqual(expected.ToString(), kyu6GiveMeADiamond.print(3));
    }

    [Test]
    public void TestDiamond5()
    {
        var expected = new StringBuilder();
        expected.Append("  *\n");
        expected.Append(" ***\n");
        expected.Append("*****\n");
        expected.Append(" ***\n");
        expected.Append("  *\n");

        Assert.AreEqual(expected.ToString(), kyu6GiveMeADiamond.print(5));
    }
}