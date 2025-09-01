using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Circle : Shape
    {
        double r;
        internal Circle(double r)
        {
            this.r = r;
        }

        internal override double Area()
        {
            double circleArea = 3.14 * r * r;
            return circleArea;
        }
    }
}
