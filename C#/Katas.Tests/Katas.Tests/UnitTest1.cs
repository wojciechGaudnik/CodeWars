using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public class Suite2Tests {

    Random randomGenerator = new Random();

    [Test]
    public void Test01() {
        Assert.AreEqual("1/2", Basics01_ConvertAnyNumber_Double_ToFraction.toFraction(0.5));
    }

    [Test]
    public void Test02() {
        Assert.AreEqual("-5/2", Basics01_ConvertAnyNumber_Double_ToFraction.toFraction(-2.5));
    }

    [Test]
    public void Test03() {
        Assert.AreEqual("2/3", Basics01_ConvertAnyNumber_Double_ToFraction.toFraction(0.66666666666));
    }

    [Test]
    public void Test04() {
        Assert.AreEqual("2", Basics01_ConvertAnyNumber_Double_ToFraction.toFraction(2));
    }

    [Test]
    public void Test05() {
        Assert.AreEqual("-717/1160", Basics01_ConvertAnyNumber_Double_ToFraction.toFraction(-0.618103448275862));
    }

    [Test]
    public void smile67KataTest_withoutRandom1()
    {
        Assert.AreEqual("3/4",  Basics01_ConvertAnyNumber_Double_ToFraction.toFraction(0.75));
    }
    [Test]
    public void smile67KataTest_withoutRandom2()
    {
        Assert.AreEqual("-1/3",  Basics01_ConvertAnyNumber_Double_ToFraction.toFraction(-0.333333333333333));
    }
    [Test]
    public void smile67KataTest_withoutRandom3()
    {
        Assert.AreEqual("3",  Basics01_ConvertAnyNumber_Double_ToFraction.toFraction(3));
    }
    [Test]
    public void smile67KataTest_withoutRandom4()
    {
        Assert.AreEqual("5/6",  Basics01_ConvertAnyNumber_Double_ToFraction.toFraction(0.833333333333333));
    }
    [Test]
    public void smile67KataTest_withoutRandom5()
    {
        Assert.AreEqual("0", Basics01_ConvertAnyNumber_Double_ToFraction.toFraction(0));
    }
}