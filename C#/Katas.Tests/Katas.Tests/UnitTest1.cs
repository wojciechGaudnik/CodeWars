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
            var SimpleFun_158_NotSoRandom=new SimpleFun_158_NotSoRandom();
            
            Assert.AreEqual("Black",SimpleFun_158_NotSoRandom.NotSoRandom(1,1));
            
            Assert.AreEqual("White",SimpleFun_158_NotSoRandom.NotSoRandom(2,1));
            
            Assert.AreEqual("Black",SimpleFun_158_NotSoRandom.NotSoRandom(1,2));
            
            Assert.AreEqual("White",SimpleFun_158_NotSoRandom.NotSoRandom(2,2));
            
            Assert.AreEqual("White",SimpleFun_158_NotSoRandom.NotSoRandom(6,9));
            
            Assert.AreEqual("White",SimpleFun_158_NotSoRandom.NotSoRandom(10000,10000));
            
            Assert.AreEqual("Black",SimpleFun_158_NotSoRandom.NotSoRandom(11111,22222));
            
        }
                 
    }
}