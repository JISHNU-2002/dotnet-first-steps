using System;
using System.Linq;
using System.Collections.Generic;

class Student{
    public int id{get; set;}
    public string name{get; set;}
    public int marks{get; set;}
    public char grade{get; set;}
    public int did{get; set;}

    public Student(int id, string name, int marks, char grade, int did){
        this.id = id;
        this.name = name;
        this.marks = marks;
        this.grade = grade;
        this.did = did;
    }
}

class Department {
    public int did { get; set; }
    public string dname { get; set; }
}

class Program{
    static void Main(){
        List<Student> students = new List<Student>{
            new Student(1, "Alice", 85, 'A', 1),
            new Student(2, "Bob", 58, 'C', 2),
            new Student(3, "Charlie", 72, 'B', 2),
            new Student(4, "David", 60, 'B', 3),
            new Student(5, "Eve", 90, 'A', 1)
        };

        List<Department> departments = new List<Department>{
            new Department { did = 1, dname = "Computer Science" },
            new Department { did = 2, dname = "Electronics" },
            new Department { did = 3, dname = "Mechanical" }
        };

        // WHERE & SELECT
        Console.WriteLine("WHERE & SELECT");
        var mW = students.Where(s => s.marks > 60);
        var qW = from s in students where s.marks > 60 select s;
        var w = string.Join(", ", mW.Select(s => s.name));
        Console.WriteLine(w);
        foreach(var i in qW){
            Console.WriteLine(i.name);
        }

        // SELECTMANY
        Console.WriteLine("\nSELECTMANY");
        List<List<int>> numberGroups = new List<List<int>> {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5 },
            new List<int> { 6, 7, 8, 9 }
        };
        // Without SelectMany, you get a list of lists
        var result = numberGroups.Select(group => group);
        foreach (var group in result) {
            foreach (var number in group) {
                Console.Write(number + " ");
            }
            Console.WriteLine(); 
        }
        var flat = numberGroups.SelectMany(num => num);
        Console.WriteLine(string.Join(", ", flat)); 

        /* OFTYPE
        1. OfType<T>() is used only on a collection like List<object>, ArrayList, or similar
        2. collection already haVING strong typing (like List<Student>), OfType<T>() 
           isn't usually needed unless the list contains multiple types
        */
        Console.WriteLine("\nOFTYPE");
        List<object> l = new List<object>{
            "Hello", 1, "World", 2.5, 3
        };
        Console.WriteLine(string.Join(", ", l.OfType<string>()));

        // ORDERBY, THENBY & ORDERBYDESCENDING
        Console.WriteLine("\nORDERBY, THENBY & ORDERBYDESCENDING");
        var mO = students.OrderBy(s => s.grade);
        Console.WriteLine(string.Join(", ", mO.Select(s => s.name))); 
        var mOT = students.OrderBy(s => s.grade).ThenBy(s => s.marks);
        var qOT = from s in students orderby s.grade, s.marks select s;
        Console.WriteLine(string.Join(", ", mOT.Select(s => s.name))); 
        Console.WriteLine(string.Join(", ", qOT.Select(s => s.name))); 

        var mOD = students.OrderByDescending(s => s.id);
        var qOD = from s in students orderby s.id descending select s;
        Console.WriteLine(string.Join(", ", mOD.Select(s => s.name))); 
        Console.WriteLine(string.Join(", ", qOD.Select(s => s.name))); 

        // GROUPBY
        Console.WriteLine("\nGROUPBY");
        var mG = students.OrderBy(s => s.grade).GroupBy(s => s.grade);
        foreach(var group in mG){
            Console.WriteLine($"Grade: {group.Key}");
            foreach(var stud in group){
                Console.WriteLine($"Student: {stud.name}");
            }
        }

        var qG = from s in students orderby s.grade group s by s.grade into grouped select grouped;
        foreach(var group in qG){
            Console.WriteLine($"Grade: {group.Key} => {string.Join(", ", group.Select(s => s.name))}");
        }

        // ToLookup only supports method syntax
        Console.WriteLine("\nToLookup");
        var lookup = students.OrderBy(s => s.grade).ToLookup(s => s.grade);
        foreach(var i in lookup){
            Console.WriteLine($"Gradelook: {i.Key} -> {string.Join(", ", i.Select(s => s.name))}");
        }
        foreach(var j in lookup['A']){
            Console.WriteLine($"{j.name} : {j.marks}");
        }

        // JOIN - Same as INNERJOIN in SQL
        Console.WriteLine("\nJOIN");
        var mJ = students.Join(departments, s => s.did, d => d.did, (s,d) => new {s.name, d.dname});
        foreach(var item in mJ){
            Console.WriteLine($"{item.name}: {item.dname}");
        }

        var qJ = from s in students join d in departments on s.did equals d.did select new { s.name, d.dname };
        foreach (var item in qJ) {
            Console.WriteLine($"{item.name}: {item.dname}");
        }

        // GROUPJOIN - Same as LEFT OUTERJOIN in SQL
        Console.WriteLine("\nGROUPJOIN");
        var mGJ = departments.GroupJoin(students,
            d => d.did, s => s.did,
            (d, stuGroup) => new {
                Department = d.dname,
                Students = stuGroup.Select(s => s.name)
            }
        );
        foreach (var group in mGJ) {
            Console.WriteLine($"{group.Department}: {string.Join(", ", group.Students)}");
        }

        var qGJ = from d in departments join s in students 
            on d.did equals s.did 
            into stuGroup
            select new{
                Department = d.dname,
                Students = stuGroup
            };
        foreach (var group in qGJ) {
            Console.WriteLine($"{group.Department}: {string.Join(", ", group.Students.Select(s => s.name))}");
        }

        Console.WriteLine("\nAny - All - Contains");
        // q = from s in students where s.grade == 'A' select s; q.Any()
        Console.WriteLine("Any Grade A: " + students.Any(s => s.grade == 'A'));
        Console.WriteLine("All Passed: " + students.All(s => s.marks >= 50));
        Console.WriteLine("Contains Bob: " + students.Select(s => s.name).Contains("Bob"));

        Console.WriteLine("\nFirst - FirstOrDefault");
        Console.WriteLine("First: " + students.First().name);
        Console.WriteLine("FirstOrDefault > 90: " + (students.FirstOrDefault(s => s.marks > 90)?.name ?? "None"));

        Console.WriteLine("\nCount - Sum - Max - Min - Average");
        Console.WriteLine("Count: " + students.Count());
        Console.WriteLine("Sum: " + students.Sum(s => s.marks));
        Console.WriteLine("Min: " + students.Min(s => s.marks));
        Console.WriteLine("Max: " + students.Max(s => s.marks));
        Console.WriteLine("Average: " + students.Average(s => s.marks));

        Console.WriteLine("\nSingle - Last - ElementAt");
        Console.WriteLine("Single Id = 1: " + students.Single(s => s.id == 1).name);
        Console.WriteLine("Last: " + students.Last().name);
        Console.WriteLine("ElementAt 2: " + students.ElementAt(2).name);

        Console.WriteLine("\nDistinct - Union - Intersect - Except");
        Console.WriteLine("Distinct: " + string.Join(", ", students.Select(s => s.did).Distinct()));
        Console.WriteLine("Union: " + string.Join(", ", students.Select(s => s.id).Union(departments.Select(d => d.did))));
        Console.WriteLine("Intersect: " + string.Join(", ", students.Select(s => s.id).Intersect(departments.Select(d => d.did))));   
        Console.WriteLine("Except: " + string.Join(", ", students.Select(s => s.id).Except(departments.Select(d => d.did))));
        
        Console.WriteLine("\nToList - ToArray - ToDictionary");
        var toList = students.ToList();
        var toArray = students.ToArray();
        var toDict = students.ToDictionary(s => s.id, s => s.name);
        Console.WriteLine("ToList Count: " + toList.Count);
        Console.WriteLine("ToArray Length: " + toArray.Length);
        Console.WriteLine("ToDictionary Keys: " + string.Join(", ", toDict.Keys));
    }   
}