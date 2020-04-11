using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public class KataTest
{
    private kyu7NinjavsSamuraiStrike ninja = new kyu7NinjavsSamuraiStrike("Ninja");
    private kyu7NinjavsSamuraiStrike samurai = new kyu7NinjavsSamuraiStrike("Samurai");

    [Test]
    public void Tests()
    {
        samurai.Strike(ninja, 4);
        Assert.AreEqual(60, ninja.Health);
    }
}