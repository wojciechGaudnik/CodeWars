using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public static class BallTests {

    private static void testing(int actual, int expected)
    {
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public static void test1()
    {
        testing(kyu6BallUpwards.MaxBall(37), 10);
        testing(kyu6BallUpwards.MaxBall(45), 13);
        testing(kyu6BallUpwards.MaxBall(99), 28);
        testing(kyu6BallUpwards.MaxBall(85), 24);
        testing(kyu6BallUpwards.MaxBall(85), 24);
        testing(kyu6BallUpwards.MaxBall(23), 7);
    }
}