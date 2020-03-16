using Katas;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CalculateStringRotationTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(4, kyu6CalculateStringRotation.ShiftedDiff("eecoff","coffee"));
            Assert.AreEqual(-1, kyu6CalculateStringRotation.ShiftedDiff("Moose","moose"));
            Assert.AreEqual(2, kyu6CalculateStringRotation.ShiftedDiff("isn't","'tisn"));
            Assert.AreEqual(0, kyu6CalculateStringRotation.ShiftedDiff("Esham","Esham"));
            Assert.AreEqual(0, kyu6CalculateStringRotation.ShiftedDiff(" "," "));
            Assert.AreEqual(-1, kyu6CalculateStringRotation.ShiftedDiff("hoop","pooh"));
            Assert.AreEqual(-1, kyu6CalculateStringRotation.ShiftedDiff("  "," "));
        }
    }
}