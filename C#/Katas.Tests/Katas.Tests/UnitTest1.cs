using NUnit.Framework;
using System;
using System.Text.RegularExpressions;
using Katas;

[TestFixture]
public class BinaryMultipleOf3Test 
{
    [Test]
    public void CheckType()
    {
        Assert.AreEqual(typeof(Regex), BinaryMultipleOf3.MultipleOf3().GetType());
        Assert.AreEqual(typeof(Match), BinaryMultipleOf3.MultipleOf3().Match("").GetType());
    }
  
    [Test]
    public void InvalidCharacters()
    {
        Assert.AreEqual(false, BinaryMultipleOf3.MultipleOf3().IsMatch(" 0"));
        Assert.AreEqual(false, BinaryMultipleOf3.MultipleOf3().IsMatch("abc"));
        Assert.AreEqual(false, BinaryMultipleOf3.MultipleOf3().IsMatch("011 110"));
    }
  
    [Test]
    public void SmallNumbers()
    {
        Assert.AreEqual(true, BinaryMultipleOf3.MultipleOf3().IsMatch("000"));
        Assert.AreEqual(false, BinaryMultipleOf3.MultipleOf3().IsMatch("001"));
        Assert.AreEqual(false, BinaryMultipleOf3.MultipleOf3().IsMatch("010"));
        Assert.AreEqual(true, BinaryMultipleOf3.MultipleOf3().IsMatch("011"));
        Assert.AreEqual(true, BinaryMultipleOf3.MultipleOf3().IsMatch("110"));
        Assert.AreEqual(false, BinaryMultipleOf3.MultipleOf3().IsMatch("111"));
    }
  
    [Test]
    public void LargeNumbers()
    {
        Assert.AreEqual(true, BinaryMultipleOf3.MultipleOf3().IsMatch(Convert.ToString(12345678, 2)));
        Assert.AreEqual(false, BinaryMultipleOf3.MultipleOf3().IsMatch(Convert.ToString(12345679, 2)));
    }
}