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
            var kata=new SimpleFun_56_BeautifulText();

            Assert.AreEqual(true,  kata.BeautifulText("Look at this example of a correct text",5,15));

            Assert.AreEqual(false,  kata.BeautifulText("abc def ghi",4,10));

            Assert.AreEqual(true,  kata.BeautifulText("a a a a a a a a",1,10));

            Assert.AreEqual(false,  kata.BeautifulText("ab cd fg xyz",1,5));

            Assert.AreEqual(true,  kata.BeautifulText("aa aa aaaaa aaaaa aaaaa",6,11));


        }

    }
}