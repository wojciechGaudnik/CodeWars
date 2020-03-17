using NUnit.Framework;
using System;
using Katas;

namespace Kata
{
    [TestFixture]
    public class ArrayTest
    {
        [Test]
        public void Test1()
        {
            var num = new int[] {2, 3, 9};
            var newNum = new int[] {2, 4, 0};
            Assert.AreEqual(newNum, kyu6Plus1Array.UpArray(num));
        }

        [Test]
        public void Test2()
        {
            var num = new int[] {4, 3, 2, 5};
            var newNum = new int[] {4, 3, 2, 6};
            Assert.AreEqual(newNum, kyu6Plus1Array.UpArray(num));
        }
    }
}