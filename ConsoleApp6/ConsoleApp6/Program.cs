using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            double circleArea = circle.Area();
            Console.WriteLine($"Area of circle: {circleArea}");

            Shape triangle = new Triangle(5, 10);
            double triangleArea = triangle.Area();
            Console.WriteLine($"Area of triangle: {triangleArea}");

            Shape rectangle = new Rectangle(5, 10);
            double rectangleArea = rectangle.Area();
            Console.WriteLine($"Area of reactangle: {rectangleArea}");
        }        
    }
}
