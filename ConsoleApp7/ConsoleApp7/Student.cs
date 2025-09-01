using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    public class Student
    {
        public readonly int id;
        public readonly string name;
        public readonly int mark;
        public readonly char grade;

        public Student(int id, string name, int mark, char grade)
        {
            this.id = id;
            this.name = name;
            this.mark = mark;
            this.grade = grade;
        }

        public static void PromoteStudent(List<Student> students, delIsPass checkPass)
        {
            foreach (Student student in students)
            {
                if (checkPass(student))
                {
                    Console.WriteLine($"{student.name} Pass");
                }
                else
                {
                    Console.WriteLine($"{student.name} Fail");
                }
            }
        }
    }
}
