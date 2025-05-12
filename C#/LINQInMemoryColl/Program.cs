using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<int> numbers = new List<int> { 2, 5, 3, 1, 4, 7, 6, 8, 9, 10 };

        // LINQ Query Syntax
        var even = from num in numbers
                   where num % 2 == 0
                   orderby num
                   select num;

        Console.WriteLine("Even Numbers (Query Syntax): " + string.Join(", ", even));

        // LINQ Method Syntax
        var EVEN = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
        Console.WriteLine("Even Numbers (Method Syntax): " + string.Join(", ", EVEN));
    }
}
