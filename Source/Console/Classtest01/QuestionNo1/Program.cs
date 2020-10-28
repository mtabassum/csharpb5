using System;

namespace QuestionNo1
{
    public class Program
    {
        static void Main(string[] args)
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
        }
    }
}
