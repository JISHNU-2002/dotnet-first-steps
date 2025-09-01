using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Rectangle : Shape
    {
        double height, width;
        internal Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        internal override double Area()
        {
            double rectangleArea = height * width;
            return rectangleArea;
        }
    }
}
