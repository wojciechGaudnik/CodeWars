using NUnit.Framework;
using System;
using System.Linq;
using System.Collections.Generic;
using Katas;

[TestFixture]
public class ShapesTests
{
    [Test]
    public void ShapesAreSortableOnArea()
    {
        // Arrange
        double width, height, triangleBase, side, radius, area;
        Random random = new Random((int)DateTime.UtcNow.Ticks);

        var expected = new List<Shape>();

        area = 1.1234;
        expected.Add(new CustomShape(area));

        side = 1.1234;
        expected.Add(new Square(side));

        radius = 1.1234;
        expected.Add(new Circle(radius));

        triangleBase = 5;
        height = 2;
        expected.Add(new Triangle(triangleBase, height));

        height = 3;
        triangleBase = 4;
        expected.Add(new Triangle(triangleBase, height));

        width = 4;
        expected.Add(new Rectangle(width, height));

        area = 16.1;
        expected.Add(new CustomShape(area));

        var actual = expected.OrderBy(x => random.Next()).ToList();

        // Act
        actual.Sort();

        // Assert
        for (var i = 0; i < 5; i++)
        {
            Console.WriteLine( expected[i].area + " : " + actual[i].area);
            Assert.AreEqual(expected[i], actual[i]);
        }

    }
}