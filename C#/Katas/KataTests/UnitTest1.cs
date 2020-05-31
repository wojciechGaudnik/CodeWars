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
            var kata=new kyu4SimpleFun27RectangleRotation();
            
            Assert.AreEqual(23,  kata.RectangleRotation(6,4));
            
            Assert.AreEqual(65,  kata.RectangleRotation(30,2));
            
            Assert.AreEqual(49,  kata.RectangleRotation(8,6));
            
            Assert.AreEqual(333,  kata.RectangleRotation(16,20));
            
        }        
    }
}