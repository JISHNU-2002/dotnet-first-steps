using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class GenericType
    {
        public T Add<T>(T x, T y)
        {
            dynamic num1 = x;
            dynamic num2 = y;
            return num1 + num2;
        }
    }

    internal class GenericType2<T>
    {
        public dynamic Mul(dynamic x, dynamic y)
        {
            return x * y;
        }
    }
}
