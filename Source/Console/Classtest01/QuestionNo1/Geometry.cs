using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionNo1
{
    public  class Geometry
    {
        public void  CalculateArea(Shape shape)
        {

            var circleArea = 3.1416 * (shape.Acircle.Radius * shape.Acircle.Radius);

            Console.WriteLine(circleArea);


        }

        public  void CalculatePerimeter(Shape shape)
        {
            
        }
    }
}
