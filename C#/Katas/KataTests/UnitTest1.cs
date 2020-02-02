using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public class BasicTests
{
    static int [][] clues = new[]
    {
        new [] { 7, 0, 0, 0, 2, 2, 3,
            0, 0, 3, 0, 0, 0, 0,
            3, 0, 3, 0, 0, 5, 0,
            0, 0, 0, 0, 5, 0, 4 },
        new [] { 0, 2, 3, 0, 2, 0, 0,
            5, 0, 4, 5, 0, 4, 0,
            0, 4, 2, 0, 0, 0, 6,
            5, 2, 2, 2, 2, 4, 1 }
    };

    static int [][][] expected = new[]
    {
        new[] { new[] { 1, 5, 6, 7, 4, 3, 2 },
            new[] { 2, 7, 4, 5, 3, 1, 6 },
            new[] { 3, 4, 5, 6, 7, 2, 1 },
            new[] { 4, 6, 3, 1, 2, 7, 5 },
            new[] { 5, 3, 1, 2, 6, 4, 7 },
            new[] { 6, 2, 7, 3, 1, 5, 4 },
            new[] { 7, 1, 2, 4, 5, 6, 3 } },
        new[] { new[] { 7, 6, 2, 1, 5, 4, 3 },
            new[] { 1, 3, 5, 4, 2, 7, 6 },
            new[] { 6, 5, 4, 7, 3, 2, 1 },
            new[] { 5, 1, 7, 6, 4, 3, 2 },
            new[] { 4, 2, 1, 3, 7, 6, 5 },
            new[] { 3, 7, 6, 2, 1, 5, 4 },
            new[] { 2, 4, 3, 5, 6, 1, 7 } }
    };


    [Test]
    public void Test_1_Medium()
    {
        var actual = SkyScrapersAll.SolvePuzzle(clues[0]);
        CollectionAssert.AreEqual(expected[0], actual);
    }

    [Test]
    public void Test_2_VeryHard()
    {
        var actual = SkyScrapersAll.SolvePuzzle(clues[1]);
        CollectionAssert.AreEqual(expected[1], actual);
    }
}