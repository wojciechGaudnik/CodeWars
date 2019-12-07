using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Katas;

public class FoldAnArrayTests
{
    [Test]
    public void BasicTests()
    {
        var input = new int[] { 1, 2, 3, 4, 5 };
        var expected = new int[] { 6, 6, 3 };
        Assert.AreEqual(string.Join(",", expected), string.Join(",", FoldAnArray.FoldArray(input, 1)));
    
        expected = new int[] { 9, 6 };
        Assert.AreEqual(string.Join(",", expected), string.Join(",", FoldAnArray.FoldArray(input, 2)));
    
        expected = new int[] { 15 };
        Assert.AreEqual(string.Join(",", expected), string.Join(",", FoldAnArray.FoldArray(input, 3)));
    
        input = new int[] { -9, 9, -8, 8, 66, 23 };
        expected = new int[] { 14, 75, 0 };
        Assert.AreEqual(string.Join(",", expected), string.Join(",", FoldAnArray.FoldArray(input, 1)));
    }
}