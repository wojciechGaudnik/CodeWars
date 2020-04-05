using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public class PlugboardTestConstruction {
    [Test]
    public void ValidConstruction() {
        var pb = new kyu6TheEnigmaMachinePart1ThePlugboard("AB");
        Assert.AreEqual('B', pb.process('A'), "A has to be translated to B with 'AB'");
        Assert.AreEqual('A', pb.process('B'), "B has to be translated to A with 'AB'");
        Assert.AreEqual('C', pb.process('C'), "C has to stay C with 'AB'");
    }
}