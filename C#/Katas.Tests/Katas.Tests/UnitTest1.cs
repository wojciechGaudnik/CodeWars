using Katas;

namespace Solution {
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Tests()
        {
            Assert.AreEqual(5 , FindTheOddInt.find_it ( new[] { 20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5 }));
        }
    }
}