using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public static class ApproxFloatTests {

    private static void assertFuzzyEquals(double act, double exp)
    {
        bool inrange;
        double merr = 1e-12;
        if (exp == 0.0)
            inrange = Math.Abs(act) <= merr;
        else {
            double e = Math.Abs((act - exp) / exp);
            inrange = e <= 1e-12;
        }
        if (inrange == false) {
            string specifier = "#.0000000000000000";
            Console.WriteLine(
                "Expected must be near: " + exp.ToString(specifier) +", but got: " + act.ToString(specifier));
        }
        Assert.AreEqual(true, inrange);
    }

    [Test]
    public static void test1() {
        Console.WriteLine("Fixed Tests: f");
        assertFuzzyEquals (kyu6FloatingPointApproximationI.f(2.6e-08), 1.29999999155e-08);
        assertFuzzyEquals (kyu6FloatingPointApproximationI.f(1.4e-09), 6.999999997549999e-10);
        assertFuzzyEquals (kyu6FloatingPointApproximationI.f(5.0e-06), 2.499996875007812e-06);
        assertFuzzyEquals (kyu6FloatingPointApproximationI.f(2.4e-07), 1.1999999280000085e-07);
    }
}