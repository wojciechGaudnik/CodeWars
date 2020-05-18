// using System;
// using System.Linq;
// using Katas;
// using NUnit.Framework;
//
// [TestFixture]
// public class MedianTests
// {
//     [Test]
//     public void SimpleTest(){
//         Warrior.ResetCompareCount();
//         try {
//             Warrior[] input = new Warrior[]{
//                 new Warrior(1),
//                 new Warrior(4),
//                 new Warrior(5),
//                 new Warrior(3),
//                 new Warrior(2),
//             };
//             Warrior.ResetCompareCount();
//             Assert.AreSame(input[3], kyu6SelectMedian.SelectMedian(input));
//             Assert.LessOrEqual(Warrior.CompareCount, 6);
//         } catch(Exception ex){
//             Assert.Fail(ex.Message);
//         }
//     }
//
//     [Test]
//     public void SimpleTest2(){
//         Warrior.ResetCompareCount();
//         try {
//             Warrior[] input = new Warrior[]{
//                 new Warrior(4),
//                 new Warrior(5),
//                 new Warrior(3),
//                 new Warrior(2),
//                 new Warrior(1),
//             };
//             Warrior.ResetCompareCount();
//             var actual = kyu6SelectMedian.SelectMedian(input);
//             Console.WriteLine(((Warrior)actual).m_internal + " <--- ((Warrior)actual).m_internal");
//             Console.WriteLine((input[2]).m_internal + " <--- (input[3]).m_internal");
//             Assert.AreSame(input[2], kyu6SelectMedian.SelectMedian(input));
//             // Assert.LessOrEqual(Warrior.CompareCount, 6);
//         } catch(Exception ex){
//             Assert.Fail(ex.Message);
//         }
//     }
//
//     [Test]
//     public void SimpleTest3(){
//         try {
//             Warrior[] input = new Warrior[]{
//                 new Warrior(5),
//                 new Warrior(3),
//                 new Warrior(2),
//                 new Warrior(1),
//                 new Warrior(4),
//             };
//             Warrior.ResetCompareCount();
//             var actual = kyu6SelectMedian.SelectMedian(input);
//             Console.WriteLine(((Warrior)actual).m_internal + " <--- ((Warrior)actual).m_internal");
//             Console.WriteLine((input[1]).m_internal + " <--- (input[1]).m_internal");
//             Assert.AreSame(input[1], actual);
//             // Assert.LessOrEqual(Warrior.CompareCount, 6);
//         } catch(Exception ex){
//             Assert.Fail(ex.Message);
//         }
//     }
// }


using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(unbleach(" \t\n"), unbleach(kyu6ConvertIntegerToWhitespaceFormat.WhitespaceNumber(1)));
            Assert.AreEqual(unbleach(" \n"), unbleach(kyu6ConvertIntegerToWhitespaceFormat.WhitespaceNumber(0)));
            Assert.AreEqual(unbleach("\t\t\n"), unbleach(kyu6ConvertIntegerToWhitespaceFormat.WhitespaceNumber(-1)));
            Assert.AreEqual(unbleach(" \t \n"), unbleach(kyu6ConvertIntegerToWhitespaceFormat.WhitespaceNumber(2)));
            Assert.AreEqual(unbleach("\t\t\t\n"), unbleach(kyu6ConvertIntegerToWhitespaceFormat.WhitespaceNumber(-3)));
        }

        private string unbleach(string ws)
        {
            return ws.Replace(" ", "[space]").Replace("\t","[tab]").Replace("\n","[LF]");
        }
    }
}