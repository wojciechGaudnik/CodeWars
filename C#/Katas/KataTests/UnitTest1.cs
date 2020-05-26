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
//             Assert.AreEqual("EVEN",kata.SubsetsParity(35,4));
//         }
//
//
//     }
// }
//

using Katas;

namespace myjinxin
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class myjinxin
    {

        [Test]
        public void BasicTests(){
            var kata=new kyu6SimpleFun19CountBlackCells();

            Assert.AreEqual(6,  kata.CountBlackCells(3,4));

            Assert.AreEqual(7,  kata.CountBlackCells(3,3));

            Assert.AreEqual(6,  kata.CountBlackCells(2,5));

            Assert.AreEqual(1,  kata.CountBlackCells(1,1));

            Assert.AreEqual(2,  kata.CountBlackCells(1,2));

            Assert.AreEqual(239,  kata.CountBlackCells(1,239));

            Assert.AreEqual(86,  kata.CountBlackCells(33,44));

            Assert.AreEqual(30,  kata.CountBlackCells(16,8));

            Assert.AreEqual(17774,  kata.CountBlackCells(6666,8888));

        }
    }
}