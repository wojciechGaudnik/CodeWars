using System;
using Katas;
using NUnit.Framework;

// tests results are given with lots of decimals but tested at 1e-2

[TestFixture]
public static class BrakingTests
{

    private static void assertFuzzyEquals(double act, double exp)
    {
        bool inrange = Math.Abs(act - exp) <= 1e-2;
        if (inrange == false)
        {
            string specifier = "#.00";
            Console.WriteLine(
                "At 1e-2: Expected must be " + exp.ToString(specifier) +", but got " + act.ToString(specifier));
        }
        Assert.AreEqual(true, inrange);
    }

    [Test]
    public static void test1()
    {
        Console.WriteLine("Fixed Tests: Dist");
        assertFuzzyEquals(kyu6BrakingWell.Dist(144, 0.3), 311.83146449201496);
        assertFuzzyEquals(kyu6BrakingWell.Dist(92, 0.5), 92.12909477605366);
        assertFuzzyEquals(kyu6BrakingWell.Dist(142, 0.2), 435.94398509960854);
        assertFuzzyEquals(kyu6BrakingWell.Dist(96, 0.2), 207.8876429946766);
    }
    [Test]
    public static void test2()
    {
        Console.WriteLine("Fixed Tests: Speed");
        assertFuzzyEquals(kyu6BrakingWell.Speed(159, 0.8), 153.79671564846308);
        assertFuzzyEquals(kyu6BrakingWell.Speed(164, 0.7), 147.91115701756493);
        assertFuzzyEquals(kyu6BrakingWell.Speed(153, 0.7), 142.14404997566152);
        assertFuzzyEquals(kyu6BrakingWell.Speed(88, 0.9), 113.64202099481099);
    }
}