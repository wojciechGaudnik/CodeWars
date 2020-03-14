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
            Assert.AreEqual(1.414,  kyu6CalculateHypotenuseOfRight_angledTriangle.CalculateHypotenuse(1, 1));
            Assert.AreEqual(5.000,  kyu6CalculateHypotenuseOfRight_angledTriangle.CalculateHypotenuse(3, 4));
            Assert.AreEqual(12.728, kyu6CalculateHypotenuseOfRight_angledTriangle.CalculateHypotenuse(9, 9));
        }
    }
}