// using Katas;
//
// namespace myjinxin
// {
//     using NUnit.Framework;
//     using System;
//
//     [TestFixture]
//     public class myjinxin
//     {
//
//         [Test]
//         public void BasicTests(){
//             var kata=new kyu4SimpleFun119SubSetsParity();
//
//             Assert.AreEqual("ODD",kata.SubsetsParity(3,2));
//             Assert.AreEqual("EVEN",kata.SubsetsParity(2,1));
//             Assert.AreEqual("ODD",kata.SubsetsParity(1,1));
//             Assert.AreEqual("EVEN",kata.SubsetsParity(20,10));
//             Assert.AreEqual("EVEN",kata.SubsetsParity(48,12));
//             // Assert.AreEqual("EVEN",kata.SubsetsParity(48000,120));
//
//         }
//
//         [Test]
//         public void BasicTests1(){
//             var kata=new kyu4SimpleFun119SubSetsParity();
//
//             Assert.AreEqual("ODD",kata.SubsetsParity(61,5));
//             Assert.AreEqual("EVEN",kata.SubsetsParity(80,14));
//             Assert.AreEqual("EVEN",kata.SubsetsParity(64,29));
//             Assert.AreEqual("EVEN",kata.SubsetsParity(71,19));
//             Assert.AreEqual("EVEN",kata.SubsetsParity(85,55));
//             Assert.AreEqual("EVEN",kata.SubsetsParity(23,9));
//         }
//
//         [Test]
//         public void BasicTests2(){
//             var kata=new kyu4SimpleFun119SubSetsParity();
//
//             Assert.AreEqual("EVEN",kata.SubsetsParity(65,19));
//             Assert.AreEqual("EVEN",kata.SubsetsParity(66,42));
//             Assert.AreEqual("EVEN",kata.SubsetsParity(34,15));
//             Assert.AreEqual("EVEN",kata.SubsetsParity(75,57));
//             Assert.AreEqual("EVEN",kata.SubsetsParity(79,36));
//             Assert.AreEqual("EVEN",kata.SubsetsParity(2,1));
//             Assert.AreEqual("ODD",kata.SubsetsParity(29,20));
//         }
//
//
//     }
// }

using Katas;
using NUnit.Framework;

[TestFixture]
class Tests
{
    [Test]
    [TestCase(new[] { 3, 8, 3, 6, 5, 7, 9, 1 }, new[] { 1, 8, 3, 3, 5, 6, 9, 7 })]
    [TestCase(new[] { 9, 4, 5, 3, 5, 7, 2, 56, 8, 2, 6, 8, 0 }, new[] { 0, 2, 2, 4, 8, 8, 3, 5, 5, 6, 9, 7, 56 })]
    public void BasicTests(int[] input, int[] expected)
    {
        Assert.That(kyu6SortingByBits.SortByBit(input), Is.EqualTo(expected));
    }
}
