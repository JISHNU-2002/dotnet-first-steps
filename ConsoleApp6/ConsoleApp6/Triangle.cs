using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Triangle : Shape
    {
        double b, h;
        public Triangle(double b, double h)
        {
            this.b = b; 
            this.h = h;
        }

        internal override double Area()
        {
            double triangleArea = 0.5 * b * h;
            return triangleArea;
        }
    }
}
