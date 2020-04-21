using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class kyu6RotateArrayJSTest
    {
        [Test]
        public void BasicTests()
        {
            var data = new object[] { 1, 2, 3, 4, 5 };
      
            Assert.AreEqual(new object[] { 5, 1, 2, 3, 4 }, kyu6RotateArrayJS.Rotate(data, 1));
            Assert.AreEqual(new object[] { 4, 5, 1, 2, 3 }, kyu6RotateArrayJS.Rotate(data, 2));
            Assert.AreEqual(new object[] { 3, 4, 5, 1, 2 }, kyu6RotateArrayJS.Rotate(data, 3));
            Assert.AreEqual(new object[] { 2, 3, 4, 5, 1 }, kyu6RotateArrayJS.Rotate(data, 4));
            Assert.AreEqual(new object[] { 1, 2, 3, 4, 5 }, kyu6RotateArrayJS.Rotate(data, 5));

            Assert.AreEqual(new object[] { 1, 2, 3, 4, 5 }, kyu6RotateArrayJS.Rotate(data, 0));

            Assert.AreEqual(new object[] { 2, 3, 4, 5, 1 }, kyu6RotateArrayJS.Rotate(data, -1));
            Assert.AreEqual(new object[] { 3, 4, 5, 1, 2 }, kyu6RotateArrayJS.Rotate(data, -2));
            Assert.AreEqual(new object[] { 4, 5, 1, 2, 3 }, kyu6RotateArrayJS.Rotate(data, -3));
            Assert.AreEqual(new object[] { 5, 1, 2, 3, 4 }, kyu6RotateArrayJS.Rotate(data, -4));
            Assert.AreEqual(new object[] { 1, 2, 3, 4, 5 }, kyu6RotateArrayJS.Rotate(data, -5));

            Assert.AreEqual(new object[] { 'c', 'a', 'b' }, kyu6RotateArrayJS.Rotate(new object[] { 'a', 'b', 'c' } , 1));
            Assert.AreEqual(new object[] { 3.0, 1.0, 2.0 }, kyu6RotateArrayJS.Rotate(new object[] { 1.0, 2.0, 3.0 }, 1));
            Assert.AreEqual(new object[] { false, true, true }, kyu6RotateArrayJS.Rotate(new object[] { true, true, false }, 1));

            Assert.AreEqual(new object[] { 4, 5, 1, 2, 3 }, kyu6RotateArrayJS.Rotate(data, 7));
            Assert.AreEqual(new object[] { 5, 1, 2, 3, 4 }, kyu6RotateArrayJS.Rotate(data, 11));
            Assert.AreEqual(new object[] { 3, 4, 5, 1, 2 }, kyu6RotateArrayJS.Rotate(data, 12478));
        }
    }
}