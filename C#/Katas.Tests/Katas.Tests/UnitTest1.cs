using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public class ASumTests {

    [Test]
    public void Test1() {
        Assert.AreEqual(2022, BuildAPileOfCubes.findNb(4183059834009));
    }
    [Test]
    public void Test2() {
        Assert.AreEqual(-1, BuildAPileOfCubes.findNb(24723578342962));
    }
    [Test]
    public void Test3() {
        Assert.AreEqual(4824, BuildAPileOfCubes.findNb(135440716410000));
    }
    [Test]
    public void Test4() {
        Assert.AreEqual(3568, BuildAPileOfCubes.findNb(40539911473216));

    }
}