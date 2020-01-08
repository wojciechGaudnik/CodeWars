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
            var kata=new SimpleFun_159_MiddlePermutation();

            Assert.AreEqual("bac",kata.MiddlePermutation("abc"));

            Assert.AreEqual("bdca",kata.MiddlePermutation("abcd"));

            Assert.AreEqual("cbxda",kata.MiddlePermutation("abcdx"));

            Assert.AreEqual("cxgdba",kata.MiddlePermutation("abcdxg"));

            Assert.AreEqual("dczxgba",kata.MiddlePermutation("abcdxgz"));

        }

    }
}