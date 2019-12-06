using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public class FinanceTests {

    [Test]
    public void Test01() {
        Assert.AreEqual(105, FinancingPlanOnPlanetXY140Z_n.finance(5));
    }
    [Test]
    public void Test02() {
        Assert.AreEqual(168, FinancingPlanOnPlanetXY140Z_n.finance(6));
    }
    [Test]
    public void Test03() {
        Assert.AreEqual(360, FinancingPlanOnPlanetXY140Z_n.finance(8));
    }
    [Test]
    public void Test04() {
        Assert.AreEqual(2040, FinancingPlanOnPlanetXY140Z_n.finance(15));
    }

}