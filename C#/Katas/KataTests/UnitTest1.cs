using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(3, kyu6LengthOfMissingArray.GetLengthOfMissingArray(new object[][] { new object[] { 1, 2 }, new object[] { 4, 5, 1, 1 }, new object[] { 1 }, new object[] { 5, 6, 7, 8, 9 }} ));
            Assert.AreEqual(2, kyu6LengthOfMissingArray.GetLengthOfMissingArray(new object[][] { new object[] { 5, 2, 9 }, new object[] { 4, 5, 1, 1 }, new object[] { 1 }, new object[] { 5, 6, 7, 8, 9 }} ));
            Assert.AreEqual(2, kyu6LengthOfMissingArray.GetLengthOfMissingArray(new object[][] { new object[] { null }, new object[] { null, null, null } } ));
            Assert.AreEqual(5, kyu6LengthOfMissingArray.GetLengthOfMissingArray(new object[][] { new object[] { 'a', 'a', 'a' }, new object[] { 'a', 'a' }, new object[] { 'a', 'a', 'a', 'a' }, new object[] { 'a' }, new object[] { 'a', 'a', 'a', 'a', 'a', 'a' }} ));

            Assert.AreEqual(0, kyu6LengthOfMissingArray.GetLengthOfMissingArray(new object[][] { }));
        }
    }
}