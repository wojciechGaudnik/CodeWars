using Katas;

namespace Solution
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {
        [Test]
        public static void ShouldWorkForSomeExamples()
        {
            Assert.AreEqual("ThIs", kyu6WelrdStringCase.ToWeirdCase("This"));
            Assert.AreEqual("Is", kyu6WelrdStringCase.ToWeirdCase("is"));
            Assert.AreEqual("ThIs Is A TeSt", kyu6WelrdStringCase.ToWeirdCase("This is a test"));
        }
    }
}