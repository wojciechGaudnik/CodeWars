using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6SortableShapes
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("test");
            var CustomShape = new CustomShape(1.1234);
            var CustomShape2 = new CustomShape(1.1234);
            var Square = new Square(1.1234);
            var list = new List<Shape>();
            list.Add(CustomShape);
            list.Add(Square);
            Console.WriteLine(CustomShape.Equals(CustomShape2));

            list.Sort();

            foreach (var one in list)
            {
                Console.WriteLine(one);

            }


        }


    }

    public abstract class Shape : IComparable
    {
        public double area;

        private bool Equals(Shape other)
        {
            return Math.Abs(this.area - other.area) < 0.000000000000001;
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Shape) obj);
        }

        public int CompareTo(object? obj)
        {
            return obj is Shape objectMy && (area < objectMy.area) ? -1 : 1;
        }
    }

    public class CustomShape : Shape
    {
        public CustomShape(double area) => this.area = area;
    }

    public class Square : Shape
    {
        public Square(double side) => this.area = side * side;
    }

    public class Circle : Shape
    {
        public Circle(double r) => this.area = Math.PI * Math.Pow(r, 2);
    }

    public class Triangle : Shape
    {
        public Triangle(double tBase, double height) => this.area = (height * tBase) / 2;
    }
    
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) => this.area = width * height;
    }
}