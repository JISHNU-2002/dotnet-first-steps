using System;
using System.Collections.Generic;

class Student{
    public int id{get; set;}
    public string name{get; set;}
    public int marks{get; set;}
}

class Program{
    static void Main(){
        var students = new List<Student>{
            new Student{ id = 1, name = "Alice", marks = 85 },
            new Student{ id = 2, name = "Bob", marks = 65 },
            new Student{ id = 3, name = "Charlie", marks = 45 }
        };

        var toppers = from s in students where s.marks >= 60 orderby s.marks select new {s.name, s.marks};
        foreach(var v in toppers){
            Console.WriteLine($"{v.name} : {v.marks}");
        }
        var top = students.Where(s => s.marks >= 60).OrderBy(s => s.marks);
        foreach(var m in toppers){
            Console.WriteLine($"{m.name} : {m.marks}");
        }
    }
}