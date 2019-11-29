using Katas;

namespace Solution {
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test, Description("It should work for basic tests")]
        public void SampleTest()
        {
            Assert.AreEqual("Hi", ExclamationMarksSeries_2_RemoveAllExclamationMarksFromTheEndFfSentence.Remove("Hi!"));
            Assert.AreEqual("Hi", ExclamationMarksSeries_2_RemoveAllExclamationMarksFromTheEndFfSentence.Remove("Hi!!!"));
            Assert.AreEqual("!Hi", ExclamationMarksSeries_2_RemoveAllExclamationMarksFromTheEndFfSentence.Remove("!Hi"));
            Assert.AreEqual("!Hi", ExclamationMarksSeries_2_RemoveAllExclamationMarksFromTheEndFfSentence.Remove("!Hi!"));
            Assert.AreEqual("Hi! Hi", ExclamationMarksSeries_2_RemoveAllExclamationMarksFromTheEndFfSentence.Remove("Hi! Hi"));
            Assert.AreEqual("Hi", ExclamationMarksSeries_2_RemoveAllExclamationMarksFromTheEndFfSentence.Remove("Hi"));
        }
    }
}