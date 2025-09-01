using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int res;
            while (true)
            {
                Console.WriteLine("Enter num1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter num1: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n1.Add\n2.Sub\n3.Mul\n4.Div\n5.Mod\n9.Exit\n\nEnter the operation: ");
                int op = Convert.ToInt32(Console.ReadLine());
                if (op == 9)
                {
                    Console.WriteLine("Exit");
                    break;
                }

                switch (op)
                {
                    case 1:
                        res = calc.Add(num1, num2);
                        Console.WriteLine($"{num1} + {num2} = {res}");
                        break;
                    case 2:
                        res = calc.Sub(num1, num2);
                        Console.WriteLine($"{num1} - {num2} = {res}");
                        break;
                    case 3:
                        res = calc.Mul(num1, num2);
                        Console.WriteLine($"{num1} * {num2} = {res}");
                        break;
                    case 4:
                        res = calc.Div(num1, num2);
                        Console.WriteLine($"{num1} / {num2} = {res}");
                        break;
                    case 5:
                        res = calc.Mod(num1, num2);
                        Console.WriteLine($"{num1} % {num2} = {res}");
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
            }

            Customer customer = new Customer();
            customer.num = 1;

            while (true)
            {
                Console.WriteLine("Enter num1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter num1: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n1.Add\n2.Sub\n3.Mul\n4.Div\n5.Mod\n9.Exit\n\nEnter the operation: ");
                int op = Convert.ToInt32(Console.ReadLine());
                if (op == 9)
                {
                    Console.WriteLine("Exit");
                    break;
                }

                switch (op)
                {
                    case 1:
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                        break;
                    case 4:
                        Console.WriteLine($"{num1} / {num2} = {Convert.ToDouble(num1 / num2)}");
                        break;
                    case 5:
                        Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Multiplication Table of {i}");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{j} * {i} = {j * i}");
                }
                Console.WriteLine(" ");
            }

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine($"{arr[i]} is even");
                }
            }

            Console.WriteLine("Enter num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num1: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operation: ");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    Console.WriteLine(Convert.ToDouble(num1 / num2));
                    break;
                case '%':
                    Console.WriteLine(num1 % num2);
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            if (box1 > box2 && box1 > box3)
            {
                Console.WriteLine("Box1 is the largest");
            }
            else if (box2 > box3)
            {
                Console.WriteLine("Box2 is the largest");
            }
            else
            {
                Console.WriteLine("Box3 is bigger");
            }

            Console.WriteLine("Enter box1: ");
            int box1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter box2: ");
            int box2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter box3: ");
            int box3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num1: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Num1 = {num1}\n Num2 = {num2}");

            Console.WriteLine("Enter DOB dd-mm-yyyy");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());
            int age = DateTime.Now.Year - dob.Year;
            Console.WriteLine("Your age = " + age);
        }
    }
}
