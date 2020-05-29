// using kyu6StringSubpatternRecognitionIs;
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

using NUnit.Framework;
using System;
using Katas;

class ExampleTest
{
    [Test]
    public void FixedTest()
    {
        Assert.AreEqual(false, kyu6StringSubpatternRecognitionI.HasSubpattern("a"));
        Assert.AreEqual(true, kyu6StringSubpatternRecognitionI.HasSubpattern("aaaa"));
        Assert.AreEqual(false, kyu6StringSubpatternRecognitionI.HasSubpattern("abcd"));
        Assert.AreEqual(true, kyu6StringSubpatternRecognitionI.HasSubpattern("abababab"));
        Assert.AreEqual(false, kyu6StringSubpatternRecognitionI.HasSubpattern("ababababa"));
        Assert.AreEqual(true, kyu6StringSubpatternRecognitionI.HasSubpattern("123a123a123a"));
        Assert.AreEqual(false, kyu6StringSubpatternRecognitionI.HasSubpattern("123A123a123a"));
        Assert.AreEqual(true, kyu6StringSubpatternRecognitionI.HasSubpattern("abbaabbaabba"));
        Assert.AreEqual(false, kyu6StringSubpatternRecognitionI.HasSubpattern("abbabbabba"));
        Assert.AreEqual(false, kyu6StringSubpatternRecognitionI.HasSubpattern("abcdabcabcd"));
    }
}
