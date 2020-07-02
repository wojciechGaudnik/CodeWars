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


// using System;
// using NUnit.Framework;
// using System.Linq;
// using System.Collections;
// using System.Collections.Generic;
//
// [TestFixture]
// public class SumOfKTests {
//
//     [Test]
//     public void Test1() {
//         Console.WriteLine("****** Basic Tests");
//         List<int> ts = new List<int> {50, 55, 56, 57, 58};
//         int? n = SumOfK.chooseBestSum(163, 3, ts);
//         Assert.AreEqual(163, n);
//
//         ts = new List<int> {50};
//         n = SumOfK.chooseBestSum(163, 3, ts);
//         Assert.AreEqual(null, n);
//
//         ts = new List<int> {91, 74, 73, 85, 73, 81, 87};
//         n = SumOfK.chooseBestSum(230, 3, ts);
//         Assert.AreEqual(228, n);
//     }
// }

using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual("test_controller", kyu5ConvertPascalCaseStringIntoSnake_case.ToUnderscore("TestController"));
            Assert.AreEqual("this_is_beautiful_day", kyu5ConvertPascalCaseStringIntoSnake_case.ToUnderscore("ThisIsBeautifulDay"));
            Assert.AreEqual("am7_days", kyu5ConvertPascalCaseStringIntoSnake_case.ToUnderscore("Am7Days"));
            Assert.AreEqual("my3_code_is4_times_better", kyu5ConvertPascalCaseStringIntoSnake_case.ToUnderscore("My3CodeIs4TimesBetter"));
            Assert.AreEqual("arbitrarily_sending_different_types_to_functions_makes_katas_cool", kyu5ConvertPascalCaseStringIntoSnake_case.ToUnderscore("ArbitrarilySendingDifferentTypesToFunctionsMakesKatasCool"));
            Assert.AreEqual("1", kyu5ConvertPascalCaseStringIntoSnake_case.ToUnderscore(1), "Numbers should be turned to strings!");
        }
    }
}