using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(true, TakeaTenMinuteWalk.IsValidWalk(new string[] {"n","s","n","s","n","s","n","s","n","s"}), "should return true");
            Assert.AreEqual(false, TakeaTenMinuteWalk.IsValidWalk(new string[] {"w","e","w","e","w","e","w","e","w","e","w","e"}), "should return false");
            Assert.AreEqual(false, TakeaTenMinuteWalk.IsValidWalk(new string[] {"w"}), "should return false");
            Assert.AreEqual(false, TakeaTenMinuteWalk.IsValidWalk(new string[] {"n","n","n","s","n","s","n","s","n","s"}), "should return false");
        }
    }
}