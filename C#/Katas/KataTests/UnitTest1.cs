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
//
//             Assert.AreEqual("EVEN",kata.SubsetsParity(2,1));
//
//             Assert.AreEqual("ODD",kata.SubsetsParity(1,1));
//
//             Assert.AreEqual("EVEN",kata.SubsetsParity(20,10));
//
//             Assert.AreEqual("EVEN",kata.SubsetsParity(48,12));
//
//             Assert.AreEqual("EVEN",kata.SubsetsParity(48000,120));
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

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class BinaryNumbersTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("1001", kyu6AddingBinaryNumbers.Add("111","10"));
            Assert.AreEqual("10010", kyu6AddingBinaryNumbers.Add("1101","101"));
            Assert.AreEqual("100100", kyu6AddingBinaryNumbers.Add("1101","10111"));
            Assert.AreEqual("11", kyu6AddingBinaryNumbers.Add("0011","00"));
            Assert.AreEqual("11", kyu6AddingBinaryNumbers.Add("00","0011"));
        }
    }
}
