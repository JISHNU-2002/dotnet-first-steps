using System.IO;

try {
    int x = 10, y = 0;
    Console.WriteLine(x / y);
} catch (DivideByZeroException e) {
    Console.WriteLine("Exception: " + e + "\n");
}

try {
    string input = "abc";
    int num = Convert.ToInt32(input);
} catch (FormatException e) {
    Console.WriteLine("Exception: " + e + "\n");
}

try {
    int[] arr = {1, 2, 3};
    Console.WriteLine(arr[5]);
} catch (IndexOutOfRangeException e) {
    Console.WriteLine("Exception: " + e + "\n");
}

try {
    string text = File.ReadAllText("data.txt");
} catch (FileNotFoundException e) {
    Console.WriteLine("Exception: " + e + "\n");
}

// finally
try {
    int a = 10, b = 0;
    Console.WriteLine(a / b);
} catch (Exception e) {
    Console.WriteLine("Exception: " + e + "\n");
} finally {
    Console.WriteLine("This always runs");
}

// throw
void CheckAge(int age) {
    if (age < 18) {
        throw new ArgumentException("Age must be 18 or older");
    }
}

try {
    CheckAge(15);
} catch (ArgumentException e) {
    Console.WriteLine("Caught error: " + e.Message);
}

try {
    int[] arr = {1, 2, 3};
    Console.WriteLine(arr[5]);
} catch (IndexOutOfRangeException e) {
    Console.WriteLine("Logging error: " + e.Message);
    throw;  // rethrows the same exception
}


