for (int row = 1; row < 11; row++) { 
    for (char column = 'a'; column < 'k'; column++) { 
        Console.Write($"({row}, {column}) -> "); 
    }
} 
Console.WriteLine("");

char[] letters = { 'a', 'b', 'c'};
foreach(char letter in letters){
    Console.WriteLine(letter);
}

string[] days = { "sunday", "monday", "saturday"};
foreach(string day in days){
    Console.WriteLine(day);
}

List<int> numbers = new List<int>() { 10, 20, 30 };
foreach (int num in numbers) {
    Console.Write(num * 2 + " -> ");
}
