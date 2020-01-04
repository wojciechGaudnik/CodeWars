using NUnit.Framework;
using System;
using Katas;

[TestFixture]
public class FindTheUnknownDigitTest 
{
    [Test]
    public void testSample()
    {
        Assert.AreEqual(2, FindTheUnknownDigit.solveExpression("1+1=?"), "Answer for expression '1+1=?' ");
        Assert.AreEqual(6, FindTheUnknownDigit.solveExpression("123*45?=5?088"), "Answer for expression '123*45?=5?088' ");      
        Assert.AreEqual(0, FindTheUnknownDigit.solveExpression("-5?*-1=5?"), "Answer for expression '-5?*-1=5?' ");
        Assert.AreEqual(-1, FindTheUnknownDigit.solveExpression("19--45=5?"), "Answer for expression '19--45=5?' ");
        Assert.AreEqual(5, FindTheUnknownDigit.solveExpression("??*??=302?"), "Answer for expression '??*??=302?' ");
        Assert.AreEqual(2, FindTheUnknownDigit.solveExpression("?*11=??"), "Answer for expression '?*11=??' ");
        Assert.AreEqual(2, FindTheUnknownDigit.solveExpression("??*1=??"), "Answer for expression '??*1=??' ");
        Assert.AreEqual(-1, FindTheUnknownDigit.solveExpression("??+??=??"), "Answer for expression '??+??=??' ");
    }
}