using Katas;
using NUnit.Framework;

[TestFixture]
public static class RankTests {


    [Test]
    public static void test1() {
        string st = "";
        int[] we = new int[] {4, 2, 1, 4, 3, 1, 2};
        Assert.AreEqual("No participants", kyu6PrizeDraw.NthRank(st, we, 4));
        st = "Addison,Jayden,Sofia,Michael,Andrew,Lily,Benjamin";
        we = new int[] {4, 2, 1, 4, 3, 1, 2};
        Assert.AreEqual("Not enough participants", kyu6PrizeDraw.NthRank(st, we, 8));
        st = "Addison,Jayden,Sofia,Michael,Andrew,Lily,Benjamin";
        we = new int[] {4, 2, 1, 4, 3, 1, 2};
        Assert.AreEqual("Benjamin", kyu6PrizeDraw.NthRank(st, we, 4));
        st = "Elijah,Chloe,Elizabeth,Matthew,Natalie,Jayden";
        we = new int[] {1, 3, 5, 5, 3, 6};
        Assert.AreEqual("Matthew", kyu6PrizeDraw.NthRank(st, we, 2));
    }
}