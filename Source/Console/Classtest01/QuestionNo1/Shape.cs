using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionNo1
{
    public class Shape
    {

       
    }


    public class Circle: Shape
    {
        float radius;

        public override double CalculateArea(double radius)
        {

            double area = 3.14 * radius * radius;
            return area;
        }

        public override double CalculatePerimeter(double radius)
        {

            double perimeter = 2 * 3.14 * radius;
            return perimeter;
        }


    }

    public class Rectangle: Shape
    {
        double width, height;
        public override double CalculateArea(double width, double height)
        {

            double area = width * height;
            return area;
        }

        public override double CalculatePerimeter(double width, double height)
        {

            double perimeter = 2*width + 2*height;
            return perimeter;
        }

    }

    public class Triangle: Shape
    {
        double side1, side2, side3;
        public override double CalculateArea(double side1, double side2, double side3)
        {
            double area = 0.5 * side1 * side2;
            return area;
        }
        public override double CalculatePerimeter(double side1, double side2, double side3)
        {

            double perimeter = side1+side2+side3;
            return perimeter;
        }
    }
}
