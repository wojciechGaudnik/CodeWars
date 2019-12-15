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
            var kata=new SimpleFun_162_PairWise();

            Assert.AreEqual(11,kata.Pairwise(new int[]{1, 4, 2, 3, 0, 5},7));

            Assert.AreEqual(1,kata.Pairwise(new int[]{1, 3, 2, 4},4));

            Assert.AreEqual(1,kata.Pairwise(new int[]{1, 1, 1},2));

            Assert.AreEqual(10,kata.Pairwise(new int[]{0, 0, 0, 0, 1, 1},1));

            Assert.AreEqual(0,kata.Pairwise(new int[]{15, 1, 1},5));

        }

    }
}