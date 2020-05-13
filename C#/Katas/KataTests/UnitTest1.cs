using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public static class EpidemTests {

    private static void testing(long act, long exp)
    {
        long r = Math.Abs(act - exp);
        bool inrange = r <= 1;
        if (inrange == false) {
            string specifier = "#.0";
            Console.WriteLine("abs(actual - expected) must be <= 1 but was " + r.ToString(specifier));
        }
        Assert.AreEqual(true, inrange);
    }
    [Test]
    public static void test1() {
        Console.WriteLine("Testing Epidemic");
        int tm = 18 ;int n = 432 ;int s0 = 1004 ;int i0 = 1 ;double b = 0.00209 ;double a = 0.51;
        testing(kyu6DiseaseSpread.Epidemic(tm, n, s0, i0, b, a), 420);
        tm = 12 ;n = 288 ;s0 = 1007 ;i0 = 2 ;b = 0.00206 ;a = 0.45;
        testing(kyu6DiseaseSpread.Epidemic(tm, n, s0, i0, b, a), 461);
        tm = 13 ;n = 312 ;s0 = 999 ;i0 = 1 ;b = 0.00221 ;a = 0.55;
        testing(kyu6DiseaseSpread.Epidemic(tm, n, s0, i0, b, a), 409);
        tm = 24 ;n = 576 ;s0 = 1005 ;i0 = 1 ;b = 0.00216 ;a = 0.45;
        testing(kyu6DiseaseSpread.Epidemic(tm, n, s0, i0, b, a), 474);
        tm = 24 ;n = 576 ;s0 = 982 ;i0 = 1 ;b = 0.00214 ;a = 0.44;
        testing(kyu6DiseaseSpread.Epidemic(tm, n, s0, i0, b, a), 460);
        tm = 20 ;n = 480 ;s0 = 1000 ;i0 = 1 ;b = 0.00199 ;a = 0.53;
        testing(kyu6DiseaseSpread.Epidemic(tm, n, s0, i0, b, a), 386);
        tm = 28 ;n = 672 ;s0 = 980 ;i0 = 1 ;b = 0.00198 ;a = 0.44;
        testing(kyu6DiseaseSpread.Epidemic(tm, n, s0, i0, b, a), 433);
        tm = 14 ;n = 336 ;s0 = 996 ;i0 = 2 ;b = 0.00206 ;a = 0.41;
        testing(kyu6DiseaseSpread.Epidemic(tm, n, s0, i0, b, a), 483);
        tm = 13 ;n = 312 ;s0 = 993 ;i0 = 2 ;b = 0.0021 ;a = 0.51;
        testing(kyu6DiseaseSpread.Epidemic(tm, n, s0, i0, b, a), 414);
        tm = 28 ;n = 672 ;s0 = 999 ;i0 = 1 ;b = 0.00197 ;a = 0.55;
        testing(kyu6DiseaseSpread.Epidemic(tm, n, s0, i0, b, a), 368);
    }
}