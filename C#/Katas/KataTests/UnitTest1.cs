using Katas;

namespace Italy {
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class PizzaTest
    {
        [Test]
        public void testNegative() {
            Assert.AreEqual(-1,kyu6PizzaPieces.maxPizza(-2));
        }

        [Test]
        public void testZero() {
            Assert.AreEqual(1,kyu6PizzaPieces.maxPizza(0));
        }

        [Test]
        public void test3() {
            Assert.AreEqual(7,kyu6PizzaPieces.maxPizza(3));
        }
    }
}