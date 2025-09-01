using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    public delegate bool delIsPass(Student student);
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>{};
            students.Add(new Student(1, "Jishnu", 90, 'A'));
            students.Add(new Student(2, "Vishnu", 80, 'B'));
            students.Add(new Student(3, "Gishnu", 70, 'C'));

            delIsPass checkPass = new delIsPass(IsPassCheck);
            Student.PromoteStudent(students, checkPass);
        }
        
        public static bool IsPassCheck(Student student)
        {
            if(student.grade == 'A')
            {
                return true;
            }
            return false;
        }
    }
}
