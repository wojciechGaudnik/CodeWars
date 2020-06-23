using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class TopsTest
    {
        [Test, Description("Should work for basic strings")]
        public void BasicTest()
        {
            Assert.AreEqual(String.Empty, kyu6StringTops.Tops(String.Empty));
            Assert.AreEqual("2", kyu6StringTops.Tops("12"));
            Assert.AreEqual("3pgb", kyu6StringTops.Tops("abcdefghijklmnopqrstuvwxyz12345"));
            Assert.AreEqual("M3pgb", kyu6StringTops.Tops("abcdefghijklmnopqrstuvwxyz1236789ABCDEFGHIJKLMN"));
        }
    }
}