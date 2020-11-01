using System;

namespace QuestionNo1
{
    public class Shape
    {
        public Shape()
        {
            acircle = new Circle();
            aRectangle = new Rectangle();
            aTriangle = new Triangle();
        }
        private Circle acircle;

        private Rectangle aRectangle;

        private Triangle aTriangle;

        public Circle Acircle { get => acircle; set => acircle = value; }
        public Rectangle ARectangle { get => aRectangle; set => aRectangle = value; }
        public Triangle ATriangle { get => aTriangle; set => aTriangle = value; }

    }


    public class Circle
    {
        private double radius;

        public double Radius { get => radius; set => radius = value; }
    }

    public class Rectangle
    {
        private double width;
        private double height;

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }
    }

    public class Triangle
    {
        private double side1;
        private double side2;
        private double side3;

        public double Side2 { get => side2; set => side2 = value; }
        public double Side1 { get => side1; set => side1 = value; }
        public double Side3 { get => side3; set => side3 = value; }
    }

    class Program
    {
        public static void Main()
        {
            double radius, width, height, side1, side2, side3;
            Console.WriteLine("Enter the radius for square");
            radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width for rectangle");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height for rectangle");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the side1 for triangle");
            side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the side2 for triangle");
            side2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the side3 for triangle");
            side3 = double.Parse(Console.ReadLine());

            Shape ashape = new Shape();

            ashape.Acircle.Radius = radius;

            ashape.ARectangle.Height = height;
            ashape.ARectangle.Width = width;

            ashape.ATriangle.Side1 = side1;
            ashape.ATriangle.Side2 = side2;
            ashape.ATriangle.Side3 = side3;

            Geometry geometry = new Geometry();
            geometry.CalculateArea(ashape);
            geometry.CalculatePerimeter(ashape);


        }
    }

}
