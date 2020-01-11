using NUnit.Framework;
using System;
using Katas;

public class ExTests
{
    [Test]
    public void TestOfZero()
    {
        var s = "This is a string exemplification!";
        var a = s;
        Assert.AreEqual(a, String_X_IterationsString.StringFunc(s, 0));
    }
    [Test]
    public void The2ndTest()
    {
        var s = "Ohh Man God Damn";
        var a = " nGOnmohaadhMD  ";
        Assert.AreEqual(a, String_X_IterationsString.StringFunc(s, 7));
    }
    [Test]
    public void The3rdTest()
    {
        var s = "Ohh Man God Damnn";
        var a = "haG mnad MhO noDn";
        Assert.AreEqual(a, String_X_IterationsString.StringFunc(s, 19));
    }
    [Test]
    public void The4rdTest()
    {
        var s = "N>?HO^^ibZ=rB\\MIlGKFKRv[O";
        var a = "ON[>v?RHKOF^K^GilbIZM=\\rB";
        Assert.AreEqual(a, String_X_IterationsString.StringFunc(s, 529));
    }
    [Test]
    public void The5rdTest()
    {
        var s = "M?xDauFiZPpbj";
        var a = "pauPMbDFZ?jxi";
        Assert.AreEqual(a, String_X_IterationsString.StringFunc(s, 64259186));
    }
}