using NUnit.Framework;
using System;
using Katas;

namespace DoragonSoruja {

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("VALID", kyu6ValidateMyPassword.validator("Username123"));
            Assert.AreEqual("INVALID", kyu6ValidateMyPassword.validator("Username"));
            Assert.AreEqual("INVALID", kyu6ValidateMyPassword.validator("123"));
            Assert.AreEqual("INVALID", kyu6ValidateMyPassword.validator("Username123!"));
            Assert.AreEqual("INVALID", kyu6ValidateMyPassword.validator("ThisPasswordIsTooLong1234"));
        }
    }
}