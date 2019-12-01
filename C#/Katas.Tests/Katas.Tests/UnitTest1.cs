using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public class CubesTests {

    [Test]
    public void Test1() {
        string s = "0 9026315 -827&()"; // "0 0 Lucky"
        String r = "0 0 Lucky";
        Assert.AreEqual(r, Hidden_Cubic_Numbers.isSumOfCubes(s));
    }
}