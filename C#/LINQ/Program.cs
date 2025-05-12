// LINQ Examples in C# - Query and Method Syntax with Outputs
using System;
using System.Linq;
using System.Collections.Generic;

class Student {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
    public string Grade { get; set; }
}

class Program {
    static void Main() {
        List<Student> students = new List<Student> {
            new Student { Id = 1, Name = "Alice", Marks = 85, Grade = "A" },
            new Student { Id = 2, Name = "Bob", Marks = 58, Grade = "C" },
            new Student { Id = 3, Name = "Charlie", Marks = 72, Grade = "B" },
            new Student { Id = 4, Name = "David", Marks = 60, Grade = "B" },
            new Student { Id = 5, Name = "Eve", Marks = 90, Grade = "A" }
        };

        Console.WriteLine("--- WHERE ---");
        var methodWhere = students.Where(s => s.Marks > 70);
        var queryWhere = from s in students where s.Marks > 70 select s;
        Console.WriteLine("Method: " + string.Join(", ", methodWhere.Select(s => s.Name)));
        Console.WriteLine("Query : " + string.Join(", ", queryWhere.Select(s => s.Name)));

        Console.WriteLine("--- OFTYPE ---");
        List<object> mixed = new List<object> { "hello", 123, "world", 456 };
        var methodOfType = mixed.OfType<string>();
        Console.WriteLine("Method: " + string.Join(", ", methodOfType));

        Console.WriteLine("--- SELECT ---");
        var methodSelect = students.Select(s => s.Name);
        var querySelect = from s in students select s.Name;
        Console.WriteLine("Method: " + string.Join(", ", methodSelect));
        Console.WriteLine("Query : " + string.Join(", ", querySelect));

        Console.WriteLine("--- SELECTMANY ---");
        List<List<int>> listOfLists = new List<List<int>> { 
            new List<int>{1, 2}, 
            new List<int>{3, 4} 
        };
        var methodSelectMany = listOfLists.SelectMany(x => x);
        Console.WriteLine("Method: " + string.Join(", ", methodSelectMany));

        Console.WriteLine("--- ORDERBY & THENBY ---");
        var methodOrder = students.OrderBy(s => s.Grade).ThenBy(s => s.Marks);
        var queryOrder = from s in students orderby s.Grade, s.Marks select s;
        Console.WriteLine("Method: " + string.Join(", ", methodOrder.Select(s => s.Name)));
        Console.WriteLine("Query : " + string.Join(", ", queryOrder.Select(s => s.Name)));

        Console.WriteLine("--- ORDERBYDESCENDING ---");
        var methodDesc = students.OrderByDescending(s => s.Marks);
        var queryDesc = from s in students orderby s.Marks descending select s;
        Console.WriteLine("Method: " + string.Join(", ", methodDesc.Select(s => s.Name)));
        Console.WriteLine("Query : " + string.Join(", ", queryDesc.Select(s => s.Name)));

        Console.WriteLine("--- GROUPBY ---");
        var methodGroup = students.GroupBy(s => s.Grade);
        foreach (var group in methodGroup) {
            Console.WriteLine($"Grade: {group.Key} => {string.Join(", ", group.Select(s => s.Name))}");
        }

        Console.WriteLine("--- TOLOOKUP ---");
        var lookup = students.ToLookup(s => s.Grade);
        foreach (var group in lookup) {
            Console.WriteLine($"Grade: {group.Key} => {string.Join(", ", group.Select(s => s.Name))}");
        }

        Console.WriteLine("--- JOIN ---");
        var ids = new List<int> { 1, 3, 5 };
        var methodJoin = ids.Join(students, id => id, s => s.Id, (id, s) => s.Name);
        Console.WriteLine("Method: " + string.Join(", ", methodJoin));

        Console.WriteLine("--- GROUPJOIN ---");
        var groupJoin = students.GroupJoin(ids, s => s.Id, id => id, (s, g) => new { s.Name, HasMatch = g.Any() });
        foreach (var item in groupJoin) Console.WriteLine($"{item.Name} => Match: {item.HasMatch}");

        Console.WriteLine("--- ANY / ALL / CONTAINS ---");
        Console.WriteLine("Any Grade A: " + students.Any(s => s.Grade == "A"));
        Console.WriteLine("All Passed: " + students.All(s => s.Marks >= 50));
        Console.WriteLine("Contains Bob: " + students.Select(s => s.Name).Contains("Bob"));

        Console.WriteLine("--- FIRST / FIRSTORDEFAULT ---");
        Console.WriteLine("First: " + students.First().Name);
        Console.WriteLine("FirstOrDefault >90: " + (students.FirstOrDefault(s => s.Marks > 90)?.Name ?? "None"));

        Console.WriteLine("--- COUNT / SUM / MIN / MAX / AVERAGE ---");
        Console.WriteLine("Count: " + students.Count());
        Console.WriteLine("Sum: " + students.Sum(s => s.Marks));
        Console.WriteLine("Min: " + students.Min(s => s.Marks));
        Console.WriteLine("Max: " + students.Max(s => s.Marks));
        Console.WriteLine("Average: " + students.Average(s => s.Marks));

        Console.WriteLine("--- SINGLE / LAST / ELEMENTAT ---");
        Console.WriteLine("Single Id=1: " + students.Single(s => s.Id == 1).Name);
        Console.WriteLine("Last: " + students.Last().Name);
        Console.WriteLine("ElementAt 2: " + students.ElementAt(2).Name);

        Console.WriteLine("--- DISTINCT / UNION / INTERSECT / EXCEPT ---");
        var grades1 = new List<string> { "A", "B", "C" };
        var grades2 = new List<string> { "B", "C", "D" };
        Console.WriteLine("Distinct: " + string.Join(", ", grades1.Distinct()));
        Console.WriteLine("Union: " + string.Join(", ", grades1.Union(grades2)));
        Console.WriteLine("Intersect: " + string.Join(", ", grades1.Intersect(grades2)));
        Console.WriteLine("Except: " + string.Join(", ", grades1.Except(grades2)));

        Console.WriteLine("--- TOLIST / TOARRAY / TODICTIONARY ---");
        var toList = students.ToList();
        var toArray = students.ToArray();
        var toDict = students.ToDictionary(s => s.Id, s => s.Name);
        Console.WriteLine("ToList Count: " + toList.Count);
        Console.WriteLine("ToArray Length: " + toArray.Length);
        Console.WriteLine("ToDictionary Keys: " + string.Join(", ", toDict.Keys));
    }
}
