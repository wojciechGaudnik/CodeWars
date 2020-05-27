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

namespace smile67Kata
{
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class smile67KataTest
    {
        [Test]
        public void smile67KataTest_withoutRandom1()
        {
            Assert.AreEqual("47", new kyu6Basics03StringsNumbersAndCalculation().calculateString(";$%§fsdfsd235??df/sdfgf5gh.000kk0000"));
        }
        [Test]
        public void smile67KataTest_withoutRandom2()
        {
            Assert.AreEqual("54929268", new kyu6Basics03StringsNumbersAndCalculation().calculateString("sdfsd23454sdf*2342"));
        }
        [Test]
        public void smile67KataTest_withoutRandom3()
        {
            Assert.AreEqual("-210908", new kyu6Basics03StringsNumbersAndCalculation().calculateString("fsdfsd235???34.4554s4234df-sdfgf2g3h4j442"));
        }
        [Test]
        public void smile67KataTest_withoutRandom4()
        {
            Assert.AreEqual("234676", new kyu6Basics03StringsNumbersAndCalculation().calculateString("fsdfsd234.4554s4234df+sf234442"));
        }
    }
}
