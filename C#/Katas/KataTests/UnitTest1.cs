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
            var kata=new kyu6SimpleFun79DeleteADigit();

            Assert.AreEqual(52,kata.DeleteDigit(152));

            Assert.AreEqual(101,kata.DeleteDigit(1001));

            Assert.AreEqual(1,kata.DeleteDigit(10));


        }

    }
}