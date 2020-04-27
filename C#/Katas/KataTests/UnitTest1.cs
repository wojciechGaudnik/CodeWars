using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public static class OpstringsTests
{
    private static void testing(string actual, string expected)
    {
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public static void test1()
    {
        Console.WriteLine("Fixed Tests Rot90Clock");
        testing(
            kyu6MovesInSquaredStringsIII.Oper(kyu6MovesInSquaredStringsIII.Rot90Clock,
                "rgavce\nvGcEKl\ndChZVW\nxNWgXR\niJBYDO\nSdmEKb"),
            "Sixdvr\ndJNCGg\nmBWhca\nEYgZEv\nKDXVKc\nbORWle");
    }

    [Test]
    public static void test2()
    {
        Console.WriteLine("Fixed Tests Diag1Sym");
        testing(
            kyu6MovesInSquaredStringsIII.Oper(kyu6MovesInSquaredStringsIII.Diag1Sym,
                "wuUyPC\neNHWxw\nehifmi\ntBTlFI\nvWNpdv\nIFkGjZ"),
            "weetvI\nuNhBWF\nUHiTNk\nyWflpG\nPxmFdj\nCwiIvZ");
    }

    [Test]
        public static void test3()
        {
        Console.WriteLine("Fixed Tests SelfieAndDiag1");
        testing(kyu6MovesInSquaredStringsIII.Oper(kyu6MovesInSquaredStringsIII.SelfieAndDiag1, "NJVGhr\nMObsvw\ntPhCtl\nsoEnhi\nrtQRLK\nzjliWg"),
            "NJVGhr|NMtsrz\nMObsvw|JOPotj\ntPhCtl|VbhEQl\nsoEnhi|GsCnRi\nrtQRLK|hvthLW\nzjliWg|rwliKg");
    }
}