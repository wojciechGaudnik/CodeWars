using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public class Suite2Tests {

    Random randomGenerator = new Random();

    [Test]
    public void Test01() {
        Assert.AreEqual("[0]", PlayingOnAChessboard.game(0));
    }
    [Test]
    public void Test02() {
        Assert.AreEqual("[1, 2]", PlayingOnAChessboard.game(1));
    }
    [Test]
    public void Test03() {
        Assert.AreEqual("[32]", PlayingOnAChessboard.game(8));
    }
//    [Test]
//    public void Test04() {
//        Assert.AreEqual("[1, 2]", PlayingOnAChessboard.game(16));
//    }
//    [Test]
//    public void Test05() {
//        Assert.AreEqual("[72169565, 48973472]", PlayingOnAChessboard.game(32));
//    }
//    [Test]
//    public void Test06() {
//        Assert.AreEqual("[35983612, 42423289]", PlayingOnAChessboard.game(65));
//    }
//    [Test]
//    public void Test07() {
//        Assert.AreEqual("[2905175, 5810447]", PlayingOnAChessboard.game(6500));
//    }
}