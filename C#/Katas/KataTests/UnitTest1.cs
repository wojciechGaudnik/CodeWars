// using NUnit.Framework;
// using System;
// using System.Text;
// using kyu6MysteriousFunctions;
//
// [TestFixture]
// public class Test
// {
//     [Test]
//     public void FixedTests()
//     {
//         Assert.AreEqual("", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("", ""));
//         Assert.AreEqual("", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("abc", ""));
//         Assert.AreEqual("", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("", "abc"));
//         Assert.AreEqual("", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("a", "b"));
//         Assert.AreEqual("a", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("a", "a"));
//         Assert.AreEqual("ac", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("abc", "ac"));
//         Assert.AreEqual("abc", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("abcdef", "abc"));
//         Assert.AreEqual("acf", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("abcdef", "acf"));
//         Assert.AreEqual("nottest", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("anothertest", "notatest"));
//         Assert.AreEqual("12356", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("132535365", "123456789"));
//         Assert.AreEqual("final", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("nothardlythefinaltest", "zzzfinallyzzz"));
//         Assert.AreEqual("acdefghijklmnoq", kyu4LongestCommonSubsequencePerformanceVersion.Lcs("abcdefghijklmnopq", "apcdefghijklmnobq"));
//     }
//
// }

using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public class Tests {

    [Test]
    public void Test1() {
        Assert.AreEqual(2, kyu6MysteriousFunction.GetNum(300));
    }
  
    [Test]
    public void Test2() {
        Assert.AreEqual(4, kyu6MysteriousFunction.GetNum(90783));
    }
  
    [Test]
    public void Test3() {
        Assert.AreEqual(0, kyu6MysteriousFunction.GetNum(123321));
    }
  
    [Test]
    public void Test4() {
        Assert.AreEqual(8, kyu6MysteriousFunction.GetNum(89282350306));
    }
  
    [Test]
    public void Test5() {
        Assert.AreEqual(5, kyu6MysteriousFunction.GetNum(3479283469));
    }
  
}