using Katas;

namespace Solution {
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest {

        [Test]
        public void ExampleTests() {
            Assert.AreEqual(11.691, kyu6CalculateTheAreaOfARegularNSidesPolygonInsideACircleOfRadiusR.AreaOfPolygonInsideCircle(3,3));
            Assert.AreEqual(8, kyu6CalculateTheAreaOfARegularNSidesPolygonInsideACircleOfRadiusR.AreaOfPolygonInsideCircle(2,4));
            Assert.AreEqual(14.86, kyu6CalculateTheAreaOfARegularNSidesPolygonInsideACircleOfRadiusR.AreaOfPolygonInsideCircle(2.5,5));
        }
    }
}