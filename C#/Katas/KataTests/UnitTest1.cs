using NUnit.Framework;
using System;
using System.Text;
using Katas;

[TestFixture]
public class Test
{
    [Test]
    public void FixedTests()
    {
        Assert.AreEqual("", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("", ""));
        Assert.AreEqual("", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("abc", ""));
        Assert.AreEqual("", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("", "abc"));
        Assert.AreEqual("", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("a", "b"));
        Assert.AreEqual("a", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("a", "a"));
        Assert.AreEqual("ac", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("abc", "ac"));
        Assert.AreEqual("abc", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("abcdef", "abc"));
        Assert.AreEqual("acf", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("abcdef", "acf"));
        Assert.AreEqual("nottest", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("anothertest", "notatest"));
        Assert.AreEqual("12356", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("132535365", "123456789"));
        Assert.AreEqual("final", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("nothardlythefinaltest", "zzzfinallyzzz"));
        Assert.AreEqual("acdefghijklmnoq", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("abcdefghijklmnopq", "apcdefghijklmnobq"));
    }

}