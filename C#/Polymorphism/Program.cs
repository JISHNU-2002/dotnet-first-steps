namespace One{
    class Calculator{
        public int Add(int a, int b){
            return a + b;
        }

        public double Add(double a, double b){
            return a + b;
        }

        public int Add(int a, int b, int c){
            return a + b + c;
        }
    }
}

namespace Two{
    interface IShape{
        void Draw();
    }

    class Circle : IShape{
        public void Draw(){
            Console.WriteLine("Drawing a Circle");
        }
    }

    class Rectangle : IShape{
        public void Draw(){
            Console.WriteLine("Drawing a Rectangle");
        }
    }
}

class Program{
    static void Main(){
        One.Calculator calc = new One.Calculator();
        Console.WriteLine(calc.Add(2, 3));       // 5
        Console.WriteLine(calc.Add(2.5, 3.5));   // 6.0
        Console.WriteLine(calc.Add(1, 2, 3));    // 6

        Two.IShape shape1 = new Two.Circle();
        Two.IShape shape2 = new Two.Rectangle();
        shape1.Draw();  // Drawing a Circle
        shape2.Draw();  // Drawing a Rectangle
    }
}
