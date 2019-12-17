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
            var kata=new SimpleFun180RepeatAdjacent();

            Assert.AreEqual(3,kata.RepeatAdjacent("ccccoodeffffiiighhhhhhhhhhttttttts"));

            Assert.AreEqual(0,kata.RepeatAdjacent("soooooldieeeeeer"));

            Assert.AreEqual(1,kata.RepeatAdjacent("ccccoooooooooooooooooooooooddee"));

            Assert.AreEqual(1,kata.RepeatAdjacent("chaaallengee"));

            Assert.AreEqual(2,kata.RepeatAdjacent("wwwwaaaarrioooorrrrr"));

            Assert.AreEqual(2,kata.RepeatAdjacent("gztxxxxxggggggggggggsssssssbbbbbeeeeeeehhhmmmmmmmitttttttlllllhkppppp"));

        }

    }
}