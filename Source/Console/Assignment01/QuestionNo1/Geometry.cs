using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionNo1
{
    class Geometry
    {
        public void CalculateArea(Shape shape)
        {

            var circleArea = 3.1416 * (shape.Acircle.Radius * shape.Acircle.Radius);
            Console.WriteLine($"Area of Circle- {circleArea}");

            var rectangleArea = shape.ARectangle.Width * shape.ARectangle.Height;
            Console.WriteLine($"Area of Rectangle- {rectangleArea}");

            var s = shape.ATriangle.Side1 + shape.ATriangle.Side2 + shape.ATriangle.Side3 / 2;

            var triangleArea = Math.Sqrt (s * (s- shape.ATriangle.Side1)*(s - shape.ATriangle.Side2)*(s- shape.ATriangle.Side3));
            Console.WriteLine($"Area of Triangle- {triangleArea}");

        }

        public void CalculatePerimeter(Shape shape)
        {
            var circlePerimeter = 2 * 3.1416 * shape.Acircle.Radius;
            Console.WriteLine($"Perimeter of Circle- {circlePerimeter}");

            var rectanglePerimeter = 2 * (shape.ARectangle.Width + shape.ARectangle.Height);
            Console.WriteLine($"Perimeter of Rectangle- {rectanglePerimeter}");

            var trianglePerimeter = shape.ATriangle.Side1 + shape.ATriangle.Side2 + shape.ATriangle.Side3;
            Console.WriteLine($"Perimeter of Triangle- {trianglePerimeter}");
        }
    }
}
