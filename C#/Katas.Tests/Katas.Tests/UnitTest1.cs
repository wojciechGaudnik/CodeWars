using System;
using System.Collections.Generic;
using System.Linq;
using Katas;
using NUnit.Framework;

[TestFixture]
public class Test
{
    [Test]
    public void ShouldWorkTest()
    {
        Assert.AreEqual(0, CatchingCarMileageNumbers.IsInteresting(3, new List<int>() { 1337, 256 }));
        Assert.AreEqual(1, CatchingCarMileageNumbers.IsInteresting(1336, new List<int>() { 1337, 256 }));
        Assert.AreEqual(2, CatchingCarMileageNumbers.IsInteresting(1337, new List<int>() { 1337, 256 }));
        Assert.AreEqual(0, CatchingCarMileageNumbers.IsInteresting(11208, new List<int>() { 1337, 256 }));
        Assert.AreEqual(1, CatchingCarMileageNumbers.IsInteresting(11209, new List<int>() { 1337, 256 }));
        Assert.AreEqual(2, CatchingCarMileageNumbers.IsInteresting(11211, new List<int>() { 1337, 256 }));
    }
}