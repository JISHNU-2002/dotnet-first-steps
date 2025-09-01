using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student
            {
                StudentId = 1,
                StudentName = "John",
                StudentClass = 8,
                TotalMark = 80
            });

            students.Add(new Student
            {
                StudentId = 2,
                StudentName = "Thomas",
                StudentClass = 8,
                TotalMark = 82
            });

            students.Add(new Student
            {
                StudentId = 3,
                StudentName = "Aurther",
                StudentClass = 9,
                TotalMark = 81
            });

            students.Add(new Student
            {
                StudentId = 3,
                StudentName = "Aurther",
                StudentClass = 9,
                TotalMark = 81
            });

            Console.WriteLine($"Student 0 - {students[1]}");


            foreach (var student in students)
            {
                Console.WriteLine($"Student ID: {student.StudentId}, Student Name: {student.StudentName}, Student Class: {student.StudentClass}, Total Marks: {student.TotalMark}");
            }
            Console.WriteLine("-------------------\nDictionary");

            Dictionary<int, string> Employee = new Dictionary<int, string>();
            Employee.Add(1, "Jishnu");
            Employee.Add(2, "Adish");
            Employee.Add(3, "Kala");
            Employee.Add(4, "Sreedarsh");
            Employee.Add(5, "Diya");
            Employee.Add(6, "Jimli");
            Employee.Add(7, "Biju");

            foreach (var emp in Employee) {
                Console.WriteLine($"{emp.Key} : {emp.Value}");
            }

            Employee.Remove(7);
            Console.WriteLine("After Remove");
            foreach (var emp in Employee)
            {
                Console.WriteLine($"{emp.Key} : {emp.Value}");
            }
            if (Employee.ContainsKey(7))
            {
                Console.WriteLine("Not deleted");
            }
            else
            {
                Console.WriteLine("Key not found");
            }
            Console.WriteLine("-------------------\nHash Table");

            Hashtable hashtable = new Hashtable();
            hashtable.Add(101, "Anna");
            hashtable.Add(102, "Padma");
            hashtable.Add(103, "Das");
            hashtable.Add(104, "Kenneth");

            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }

            Console.WriteLine("-------------------\nGeneric Type");
            GenericType genericType = new GenericType();
            GenericType2<float> genericType2 = new GenericType2<float>();
            int sum = genericType.Add(5, 10);
            Console.WriteLine(sum);
            string resString = genericType.Add("Hello", " World");
            Console.WriteLine(resString);

            float prod = genericType2.Mul(11.11f, 33.33f);
            Console.WriteLine(prod);


            Console.WriteLine("-------------------\nPartial Class Demo");
            Customer customer = new Customer(1, "Jishnu");
            customer.display();

            Console.WriteLine("-------------------\nenum");
            Console.Write("Enter the number : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: Console.WriteLine(Day.Monday.ToString()); break;
                case 2: Console.WriteLine(Day.Tuesday.ToString()); break;
                case 3: Console.WriteLine(Day.Wednesday.ToString()); break;
                case 4: Console.WriteLine(Day.Thursday.ToString()); break;
                case 5: Console.WriteLine(Day.Friday.ToString()); break;
                case 6: Console.WriteLine(Day.Saturday.ToString()); break;
                case 7: Console.WriteLine(Day.Sunday.ToString()); break;
                default:  break;
            }

            if (Enum.IsDefined(typeof(WeekDay), choice))
            {
                WeekDay day = (WeekDay)choice;
                Console.WriteLine(day.ToString());  
            }
            else
            {
                Console.WriteLine("Invalid day number");
            }
        }
    }
}
