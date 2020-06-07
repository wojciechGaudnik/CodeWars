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
        Console.WriteLine("Fixed Tests Rot90Counter");
        testing(kyu6MovesInSquaredStringsIV.Oper(kyu6MovesInSquaredStringsIV.Rot90Counter, "EcGcXJ\naaygcA\nNgIshN\nyOrCZE\neBEqpm\nNkxCgw"),
            "JANEmw\nXchZpg\ncgsCqC\nGyIrEx\ncagOBk\nEaNyeN");

        Console.WriteLine("Fixed Tests Diag2Sym");
        testing(kyu6MovesInSquaredStringsIV.Oper(kyu6MovesInSquaredStringsIV.Diag2Sym, "LmvLyg\nDKELBm\nylJhui\nXRXqHD\nzlisCT\nhPqxYb"),
            "bTDimg\nYCHuBy\nxsqhLL\nqiXJEv\nPlRlKm\nhzXyDL");

        Console.WriteLine("Fixed Tests SelfieDiag2Counterclock");
        testing(kyu6MovesInSquaredStringsIV.Oper(kyu6MovesInSquaredStringsIV.SelfieDiag2Counterclock,
                "NJVGhr\nMObsvw\ntPhCtl\nsoEnhi\nrtQRLK\nzjliWg"),
            "NJVGhr|gKilwr|rwliKg\nMObsvw|WLhtvh|hvthLW\ntPhCtl|iRnCsG|GsCnRi\nsoEnhi|lQEhbV|VbhEQl\nrtQRLK|jtoPOJ|JOPotj\nzjliWg|zrstMN|NMtsrz");
    }
}