using NUnit.Framework;
using System;
using Katas;

[TestFixture]
public class ThirstyInTests
{
    [Test]
    public void WaterFor37Days()
    {
        Assert.AreEqual(37, VaultExperience_1__EnoughWaterForHowManyDays.ThirstyIn(150, new int[] { 5, 30, 10 }));
    }
}