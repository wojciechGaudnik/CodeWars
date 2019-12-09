using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public class Suite2Tests {

    Random randomGenerator = new Random();

    [Test]
    public void Test01() {
        Assert.AreEqual("2", Basics01_ConvertAnyNumber_Double_ToFraction.Game666(2));
    }
//    [Test]
//    public void Test02() {
//        Assert.AreEqual("[1, 2]", Basics01_ConvertAnyNumber_Double_ToFraction.game(1));
//    }
//    [Test]
//    public void Test03() {
//        Assert.AreEqual("[32]", Basics01_ConvertAnyNumber_Double_ToFraction.game(8));
//    }

}