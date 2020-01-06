using Katas;
using NUnit.Framework;

public class SolutionTest
{

    [Test]
    public void sampleTests()
    {

        string a = ".W.\n" +
                   ".W.\n" +
                   "...",

            b = ".W.\n" +
                ".W.\n" +
                "W..",

            c = "......\n" +
                "......\n" +
                "......\n" +
                "......\n" +
                "......\n" +
                "......",

            d = "......\n" +
                "......\n" +
                "......\n" +
                "......\n" +
                ".....W\n" +
                "....W.";

        Assert.AreEqual(true, PathFinder_1CanYouReachTheExit.PathFinder(a));
        Assert.AreEqual(false, PathFinder_1CanYouReachTheExit.PathFinder(b));
        Assert.AreEqual(true, PathFinder_1CanYouReachTheExit.PathFinder(c));
        Assert.AreEqual(false, PathFinder_1CanYouReachTheExit.PathFinder(d));
    }
}