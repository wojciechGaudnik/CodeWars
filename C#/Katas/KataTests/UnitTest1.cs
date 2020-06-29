// using kyu5RGBToHexConversions;
//
// namespace Solution {
//     using NUnit.Framework;
//     using System;
//
//     public struct LDCase {
//         public int[] test;
//         public int expect;
//         public LDCase(int[] t, int e) {
//             test = t;
//             expect = e;
//         }
//     }
//
//     [TestFixture]
//     public class SolutionTest {
//         [Test]
//         public void SampleTest() {
//             Random rnd = new Random();
//             int rand1 = rnd.Next(0,100);
//             int rand2 = rnd.Next(0,10);
//
//             LDCase[] allCases = new LDCase[] {
//                 new LDCase(new int[0],           1),
//                 new LDCase(new int[] {0,0},      1),
//                 new LDCase(new int[] {0,0,0},    0),
//                 new LDCase(new int[] {1,2},      1),
//                 new LDCase(new int[] {3,4,5},    1),
//                 new LDCase(new int[] {4,3,6},    4),
//                 new LDCase(new int[] {7,6,21},   1),
//                 new LDCase(new int[] {12,30,21}, 6),
//                 new LDCase(new int[] {2,2,2,0},  4),
//                 new LDCase(new int[] {937640,767456,981242}, 0),
//                 new LDCase(new int[] {123232,694022,140249}, 6),
//                 new LDCase(new int[] {499942,898102,846073}, 6),
//
//                 new LDCase(new int[] {rand1}, rand1%10),
//                 new LDCase(new int[] {rand1,rand2}, (int)Math.Pow(rand1%10,rand2)%10)
//             };
//             for(int i=0; i<allCases.Length;i++) {
//                 Assert.AreEqual(allCases[i].expect, kyu3LastDigitOfaHugeNumber.LastDigit(allCases[i].test));
//             }
//         }
//
//         [Test]
//         public void SampleTestMy()
//         {
//             Assert.AreEqual(96, kyu3LastDigitOfaHugeNumber.IfEven(62, 48));
//             Assert.AreEqual(84, kyu3LastDigitOfaHugeNumber.IfEven(2, 34));
//
//         }
//     }
// }


using NUnit.Framework;
using System;
using Katas;

public class PerfectPowerTest
{
    [Test]
    public void Test0()
    {
        Assert.IsNull(kyu5WhatsAPerfectPowerAnyway.IsPerfectPower(0), "0 is not a perfect number");
    }

    [Test]
    public void Test1()
    {
        Assert.IsNull(kyu5WhatsAPerfectPowerAnyway.IsPerfectPower(1), "1 is not a perfect number");
    }

    [Test]
    public void Test2()
    {
        Assert.IsNull(kyu5WhatsAPerfectPowerAnyway.IsPerfectPower(2), "2 is not a perfect number");
    }

    [Test]
    public void Test3()
    {
        Assert.IsNull(kyu5WhatsAPerfectPowerAnyway.IsPerfectPower(3), "3 is not a perfect number");
    }

    [Test]
    public void Test4()
    {
        Assert.AreEqual((2, 2), kyu5WhatsAPerfectPowerAnyway.IsPerfectPower(4), "4 = 2^2");
    }

    [Test]
    public void Test5()
    {
        Assert.IsNull(kyu5WhatsAPerfectPowerAnyway.IsPerfectPower(5), "5 is not a perfect power");
    }

    [Test]
    public void Test8()
    {
        Assert.AreEqual((2, 3), kyu5WhatsAPerfectPowerAnyway.IsPerfectPower(8), "8 = 2^3");
    }

    [Test]
    public void Test9()
    {
        Assert.AreEqual((3, 2), kyu5WhatsAPerfectPowerAnyway.IsPerfectPower(9), "9 = 3^2");
    }

    [Test]
    public void TestUpTo500()
    {
        var pp = new int[] { 4, 8, 9, 16, 25, 27, 32, 36, 49, 64, 81, 100, 121, 125, 128, 144, 169, 196, 216, 225, 243, 256, 289, 324, 343, 361, 400, 441, 484 };
        foreach (var i in pp)
            Assert.IsNotNull(kyu5WhatsAPerfectPowerAnyway.IsPerfectPower(i), $"{i} is a perfect power");
    }
}