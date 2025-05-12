## Week 1: Basics
- [x] Learn variables and data types (`int`, `double`, `string`, `bool`, `char`)
- [x] Constants and Enumerations
- [x] Understand control structures (`if`, `switch`, `break`, `continue`, `return`)
- [x] Practice loops (`for`, `while`, `foreach`)
- [x] Type conversion & casting
- [x] String Manipulation
- [x] Simple console input/output
- [x] Functions (methods): Definition, Parameters, Return Values
- [x] Method Overloading
- [x] `ref`, `out`, `params` keywords
- [x] Exception Handling: `try`, `catch`, `finally`, `throw`
- [x] Working with `System.IO`
- [x] File I/O (reading/writing to files) 
- [x] Read and Write Text Files (`StreamReader`, `StreamWriter`)
- [x] Binary Files (`FileStream`)
- [x] Directory and FileInfo Classes
- [x] Strings and StringBuilder
---
## Week 2: OOP
- [x] Classes and Objects
- [x] Constructors
- [x] Static vs Instance Members
- [x] Encapsulation & Access Modifiers (`public`, `private`, `protected`, `internal`)
- [x] Field 
- [x] Property
- [x] Indexers
- [x] Inheritance
- [x] Method Overriding and `virtual`/`override`
- [x] Interfaces
- [x] Abstract Classes
- [x] Polymorphism
---
## Week 3: Collections, LINQ, File I/O
- [x] Arrays and Multidimensional Arrays
- [x] List
- [x] Tuple and Record
- [x] Dictionary
- [x] HashSet
- [x] Stack
- [x] Queue
- [x] Collection Initialization and Iteration
- [x] Practice LINQ queries (`Where`, `Select`, `OrderBy`, `GroupBy`, `Aggregate`)
- [x] Read/write files using `StreamReader` and `StreamWriter`
---
## Week 4: Delegates & Async
- [ ] Delegates/Anonymous Methods
- [ ] Events
- [ ] `Action`, `Func`, and `Predicate`
- [ ] Lambda Expressions
- [ ] Anonymous Methods
- [ ] Use async/await and Tasks `async` and `await`
- [ ] Tasks and Parallelism
- [ ] `Task.Run`, `Task.Delay`, `Task.WhenAll`
- [ ] Cancellation Tokens
---
## Week 5: Windows Forms (Optional UI Layer) & Advanced Topics
- [ ] Create a Windows Forms Project
- [ ] Buttons, Textboxes, Labels
- [ ] Event Handlers
- [ ] DataGridView
- [ ] Simple Form Validation
- [ ] Reflection
- [ ] Attributes
- [ ] Generics
- [ ] Dependency Injection (basic concept)
- [ ] Logging
- [ ] Unit Testing with MSTest/xUnit/NUnit
---

| Week | Projects                                                                                                                                                                                                                                                                                                                         |
| ---- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 1    | - [ ] Create a simple calculator<br>- [ ] Temperature converter<br>- [ ] Number guessing game<br>- [ ] Text Analyzer<br>- [ ] Bank Account Manager (Deposit, Withdraw, Balance)<br>- [ ] Prime Checker with Exception for invalid inputs<br>- [ ] Log File Writer<br>- [ ] Daily Notes Saver <br>- [ ] Contact Saver in CSV File |
| 2    | - [ ] Build a Student Management System<br>- [ ] Library Management (OOP structure)<br>- [ ] Employee Payroll System<br>- [ ] Vehicle Inheritance Example                                                                                                                                                                        |
| 3    | - [ ] Student Marksheet Generator<br>- [ ] Phonebook <br>- [ ] AppInventory System with LINQ Search                                                                                                                                                                                                                              |
| 4    | - [ ] Notification System (Events)<br>- [ ] Button Click Simulation<br>- [ ] Sorting and Filtering Data using Delegates and Lambda<br>- [ ] Weather Data Fetcher (simulate with delay)<br>- [ ] File Downloader (Async simulation)<br>- [ ] Parallel Matrix Multiplication                                                       |
| 5    | - [ ] Calculator (GUI)<br>- [ ] To-Do List<br>- [ ] Student Registration Form                                                                                                                                                                                                                                                    |

---
# C-Sharp(#)

- The C# language is the most popular language for the .NET platform
- C# is in the C family of languages
- C# syntax is familiar if you used C, C++, JavaScript, TypeScript, or Java
- Like C and C++, semi-colons ( ; ) define the end of statements
- C# identifiers are case-sensitive
- C# has the same use of braces, { and } , control statements like if , else and switch , and looping constructs like for , and while 
- C# also has a foreach statement for any collection type

```C#
using System; 
class Program { 
	static void Main() { 
	// This line prints "Hello, World"  
	Console.WriteLine("Hello, World"); 
} }
```

```bash
dotnet new console -o HelloWorld
cd HelloWorld
dotnet run
```


### Datatypes
- In C#, the `var` keyword allows you to declare a local variable without explicitly specifying its type

| Type              | Bits         | Range                                   | Method                |
| ----------------- | ------------ | --------------------------------------- | --------------------- |
| `Byte`            | 8            | 0 to 255                                | `Convert.ToByte()`    |
| `Int16` / `short` | 16           | –32,768 to 32,767                       | `Convert.ToInt16()`   |
| `Int32` / `int`   | 32           | –2 billion to 2 billion                 | `Convert.ToInt32()`   |
| `Int64` / `long`  | 64           | ±9 quintillion                          | `Convert.ToInt64()`   |
| `Double`          | 64           | Very large floating point numbers       | `Convert.ToDouble()`  |
| `Boolean`         | 1            | `true` or `false`                       | `Convert.ToBoolean()` |
| `Decimal`         | 128          | ±79,228,162,514,264,337,593,543,950,335 | `Convert.ToDecimal()` |
| `String`          | 16/character | N/A                                     | `Convert.ToString()`  |
| `char`            | 16           |                                         |                       |
| `float`           | 32           |                                         |                       |

#### CONST & ENUM
- A `const` is a variable whose **value is fixed at compile time** and **cannot be changed** during the program execution
- An `enum` is a **set of named constants** representing **integral values**, making code more readable and manageable
- An `enum` is a special "class" that represents a group of **constants** (unchangeable/read-only variables)
- By default, the first item of an enum has the value 0
- You can also assign your own enum values, and the next items will update their numbers accordingly

```C#
enum StatusCode { Success = 200, NotFound = 404, ServerError = 500 }

Console.WriteLine(StatusCode.Success);     // Output: Success
Console.WriteLine((int)StatusCode.Success); // Output: 200
```


```C#
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");
```
- C# Notice that the answer is very close to the minimum (negative) integer. It's the same as min + 2
- The addition operation overflowed the allowed values for integers. The answer is a large negative number because an overflow "wraps around" from the largest possible integer value to the smallest
- The double numeric type represents a double-precision floating point number. Those terms might be new to you. A floating point number is useful to represent nonintegral numbers that might be large or small in magnitude
- The decimal type has a smaller range but greater precision than double

## Tuples
- Tuples are an ordered sequence of values with a fixed length
- Each element of a tuple has a type and an optional name

### Record type
- `public record Point(int X, int Y);` is **not allowed before top-level statements** unless you're using a class-based structure.
- You're writing `public static void Main()` **after** the record definition — this violates the **top-level statement rules**

```C#
public record Point(int X, int Y);

public class Program{
	public static void Main(){
		Point p1 = new Point(1, 1);
		var p2 = p1 with { Y = 10 };
		Console.WriteLine($"The two points are {p1} and {p2}");
	}
}
```

```C#
record Point(int X, int Y);

Point p1 = new Point(1, 1);
var p2 = p1 with { Y = 10 };
Console.WriteLine($"The two points are {p1} and {p2}");
```

### Type Conversion and Casting
#### 1. **Implicit Conversion (Automatic)**
- Done automatically by the compiler
- Safe, no data loss
- Happens when converting from **smaller to larger** types
- Supported conversions
	- `int → long → float → double`
	- `char → int`
	- `byte → int`
```C#
int a = 5;
double b = a;  // Automatically converts int to double
Console.WriteLine(b); // Output: 5
```
#### 2. **Explicit Conversion (Manual Casting)**
- You must use a **cast operator**
- May cause **data loss**
- Happens when converting **larger to smaller** types 

```C#
double d = 9.81;
int i = (int)d;  // Must use cast
Console.WriteLine(i); // Output: 9
```

```C#
string str = "123";
int num = Convert.ToInt32(str);
Console.WriteLine(num); // Output: 123
```

```C#
string str = "56";
int number = int.Parse(str);
Console.WriteLine(number); // Output: 56
```

```C#
char c = 'A';
int ascii = c;  // Implicit
Console.WriteLine(ascii); // Output: 65

char ch = (char)ascii;  // Explicit
Console.WriteLine(ch);  // Output: A
```

### Console input and output
```C#
string name = Console.ReadLine();
char ch = Convert.ToChar(Console.ReadLine());
int num = Convert.ToInt32(Console.ReadLine());
double price = Convert.ToDouble(Console.ReadLine());
```

## Math
- The C# Math class has many methods that allows you to perform mathematical tasks on numbers
```C#
Math.Max(5, 10);
```

```csharp
Math.Min(5, 10);
```

```csharp
Math.Sqrt(64);
```

```csharp
Math.Abs(-4.7);
```

```csharp
Math.Round(9.99);
```

## String
- **Immutable**: Once created, the value of a `string` cannot be changed
- Any operation that seems to modify a string (like concatenation) actually creates a new string object in **memory**

```csharp
string name = firstName + lastName;
```

```csharp
string name = string.Concat(firstName, lastName);
```

```csharp
string name = $"My full name is: {firstName} {lastName}"; // interpolation
```

| Escape character | Result      | Description  |
| ---------------- | ----------- | ------------ |
| \'               | '           | Single quote |
| \"               | "           | Double quote |
| \\               | \|Backslash |              |
| \n, \t           |             |              |
| \b               | Backspace   |              |

### StringBuilder
- **Mutable**: Can be modified without creating a new object each time
- Much more efficient when performing repeated modifications like appending or inserting
- **Namespace**: `System.Text`

```C#
using System.Text;

StringBuilder sb = new StringBuilder("John");
sb.Append(" Doe");
Console.WriteLine(sb.ToString());  // Output: John Doe
```
### Ternary Operator
- There is also a **short-hand if else**, which is known as the **ternary operator** because it consists of three operands
- It can be used to replace multiple lines of code with a single line. It is often used to replace simple if else statements
```csharp
variable = (condition) ? expressionTrue :  expressionFalse;
```

### Named Arguments
- It is also possible to send arguments with the `_key: value_` syntax

```csharp
static void MyMethod(string child1, string child2, string child3) {
  Console.WriteLine("The youngest child is: " + child3);
}

static void Main(string[] arg){
  MyMethod(child3: "John", child1: "Liam", child2: "Liam");
}
// The youngest child is: John
```

### Call by Reference
- The importance of **reference passing (`ref` and `out`)** in C# lies in **how data is shared between methods and their callers**
- Normally, arguments are passed **by value** in C#, which means a copy of the data is made and passed to the method
- With **reference passing**, the method works with the **original variable**, allowing it to **modify the caller’s data directly** 

#### `ref` & `out`
- Passing by reference avoids copying large data structures
- Since a method can only return one value directly, using `out` allows returning **multiple values**
- With `ref`, the method can change the value and the change is visible to the caller

## Namespace
- A **namespace** in C# is a **container** that holds classes, interfaces, methods, and other namespaces. It helps **organize your code** and **prevent naming conflicts**
- **Small programs** can work without namespaces, but for **larger applications**, namespaces are highly recommended for organization and clarity

```C#
// Built-in Namespaces
using System;      // for Console, String, etc.
using System.IO;   // for file operations
using System.Collections.Generic; // for List, Dictionary, etc.
```

1. **Organizes Code**: Groups related classes and methods together
2. **Avoids Name Conflicts**: Two classes with the same name can exist in different namespaces
3. **Makes Code Readable and Scalable**: Larger projects are easier to maintain

```C#
namespace ProjectA {
    class Utils {
        public static void Print() {
            Console.WriteLine("From ProjectA");
        }
    }
}

namespace ProjectB {
    class Utils {
        public static void Print() {
            Console.WriteLine("From ProjectB");
        }
    }
}

class Program {
    static void Main(string[] args) {
        ProjectA.Utils.Print();  // Output: From ProjectA
        ProjectB.Utils.Print();  // Output: From ProjectB
    }
}
```

# File Handling
- Working with `System.IO` in C# allows you to handle **File Input/Output (I/O)** — reading from and writing to files
- The `File` class from the `System.IO` namespace, allows us to work with files
- This is part of the `.NET` base class library and provides powerful and flexible tools for file handling

```C#
using System.IO // Namespace
```

| Class          | Purpose                                   |
| -------------- | ----------------------------------------- |
| `File`         | Static methods for file operations        |
| `FileInfo`     | Instance methods for file manipulation    |
| `Directory`    | Static methods for directory manipulation |
| `StreamReader` | Read text from files                      |
| `StreamWriter` | Write text to files                       |
| `BinaryReader` | Read binary data                          |
| `BinaryWriter` | Write binary data                         |

```C#
Directory.CreateDirectory("MyFolder");  // Create folder
Directory.Exists("MyFolder");
Directory.GetFiles(".");  // Get all files in current dir

File.Copy("sample.txt", "copy_sample.txt", overwrite: true);
File.Move("copy_sample.txt", "moved_sample.txt");
File.Delete("moved_sample.txt");
File.Exists("sample.txt")
```

# Object-Oriented Programming using Csharp
## 1. Class
- A **class** is a blueprint or template for creating objects
- It defines the **properties (fields)** and **methods (functions)** that the objects created from the class will have

## 2. Object
- An **object** is an **instance** of a class
- When you create an object, you're allocating memory and accessing the class members using that object

## 3. Constructor
- A **constructor** is a **special method** in a class that is **automatically called** when an object is created
- Its main purpose is to **initialise the object’s fields** when it is instantiated
- Has the **same name** as the class
- **No return type**, not even `void`
- Automatically invoked when an object is created
- Can be **overloaded** (you can have multiple constructors with different parameters)

### Private Constructor
- A **private constructor** is used when you don’t want other classes to create objects of that class (often used in Singleton Design Pattern)

## 4. Encapsulation
- It refers to the **binding of data (variables)** and **methods (functions)** that operate on the data into a **single unit** (class), and **restricting direct access** to some of an object’s components
- The act of hiding the internal state and requiring all interaction to be performed through an object's methods
	- Protect data from unauthorised access or modification
	- Make the code **modular**, **manageable**, and **easier to debug**
	- Improve **security**, **flexibility**, and **control** over the data

```C#
using System;

class BankAccount{
    private double balance;  // Cannot be accessed directly from outside

    public void Deposit(double amount){
        if (amount > 0){
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
        else{
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public double GetBalance(){
        return balance;
    }
}

class Program{
    static void Main(){
        BankAccount account = new BankAccount();
        // account.balance = 5000; // Not allowed (private)
        account.Deposit(1000);    
        account.Deposit(-500);    
        Console.WriteLine("Balance: " + account.GetBalance()); 
    }
}
```

### Access Modifiers
| Modifier             | Same Class | Derived Class (same/diff assembly) | Same Assembly | Other Assemblies |
| -------------------- | ---------- | ---------------------------------- | ------------- | ---------------- |
| `public`             | ✅          | ✅                                  | ✅             | ✅                |
| `private`            | ✅          | ❌                                  | ❌             | ❌                |
| `protected`          | ✅          | ✅ (only derived)                   | ❌             | ❌                |
| `internal`           | ✅          | ✅ (if in same assembly)            | ✅             | ❌                |
| `protected internal` | ✅          | ✅ (if derived or same assembly)    | ✅             | ✅ (if derived)   |
| `private protected`  | ✅          | ✅ (only derived & same assembly)   | ✅             | ❌                |

### Field v/s Property

```C#
class Person{
    // Field
    private string name;

    // Property for name
    public string Name{
        get{ 
		    return name; 
		}
        set{
            if (!string.IsNullOrEmpty(value))
                name = value;
            else
                Console.WriteLine("Invalid name");
        }
    }

    // Auto-implemented property (C# shortcut)
    public int Age{
	    get; 
	    set; 
	}
}

class Program{
    static void Main(){
        Person p = new Person();

        // Accessing through property (safe, validated)
        p.Name = "John";      
        Console.WriteLine(p.Name); // Output: John

        p.Age = 25;           // Direct access using auto-property
        Console.WriteLine(p.Age);  // Output: 25

        // p.name = "Direct"; // Error: field is private
    }
}
```

| **Field**                                        | **Property**                                            |
| ------------------------------------------------ | ------------------------------------------------------- |
| A **variable** declared inside a class or struct | A **member** that provides controlled access to a field |
| Direct access (not recommended if public)        | Controlled access using `get` and `set` accessors       |
| Poor (if public); violates encapsulation         | Strong (can validate/set logic in `set`)                |
| Simple variable syntax                           | Uses `{ get; set; }` syntax                             |
| Internal class use (usually `private`)           | Interface to access private data from outside the class |
| Can be inherited but not overridden              | Can be **virtual** or **abstract** and **overridden**   |
| `private int age;`                               | `public int Age { get; set; }`                          |

### Static v/s Instance Member
- **static members** belong to the **class itself**, not to any specific object (instance) of the class
- You **do not need to create an object** to access a static member
- A static member is **shared across all instances** of the class

| Static Member        | Description                                                                                     |
| -------------------- | ----------------------------------------------------------------------------------------------- |
| `static` field       | Shared variable across all instances                                                            |
| `static` method      | Can be called without creating an object                                                        |
| `static` property    | Same as static field, but with controlled access                                                |
| `static` constructor | Initialises static data; called **once** before the first use of the class, Takes no parameters |

| Feature           | Instance Members                | Static Members                        |
| ----------------- | ------------------------------- | ------------------------------------- |
| Belongs to        | Object (instance)               | Class                                 |
| Accessed using    | Object name (`obj.method`)      | Class name (`ClassName.method`)       |
| Memory allocation | Each object gets its own copy   | Single copy shared across all objects |
| Use case          | Data/behavior varies per object | Common data or utility methods        |

## 5. Inheritance
- **Inheritance** allows one class (**child/derived class**) to inherit fields, methods, and properties from another class (**parent/base class**)
- This promotes **code reuse**, **extensibility**, and **hierarchical class structure**

| Inheritance Type       | Supported             | Example Source       |
| ---------------------- | --------------------- | -------------------- |
| Single Inheritance     | ✅ Yes                 | `class B : A`        |
| Multilevel Inheritance | ✅ Yes                 | `C : B : A`          |
| Hierarchical           | ✅ Yes                 | `B : A, C : A`       |
| Multiple (class)       | ❌ No                  | -                    |
| Multiple (interface)   | ✅ Yes                 | `class A : I1, I2`   |
| Hybrid                 | ✅ Yes (via interface) | Classes + Interfaces |

### `base` Keyword
- `base` keyword is used in derived class to:
1. **Access members** (fields, properties, methods) of the **base class**
2. **Call the base class constructor** from the derived class constructor
- Used to **access the base class version** of an overridden method

## 6. Polymorphism
- It allows **one interface or method to behave differently based on the object** that invokes it

| Type                      | Description                                 |
| ------------------------- | ------------------------------------------- |
| **Compile-time (Static)** | Method Overloading and Operator Overloading |
| **Run-time (Dynamic)**    | Method Overriding using inheritance         |
### Method Overriding
- **Method overriding** allows a **derived class** to provide a **specific implementation** of a method that is already defined in its **base class**
- To enable method overriding:
	- The method in the base class must be marked as `virtual`
	- The method in the derived class must be marked as `override`

## 7. Abstraction
- It refers to the concept of **hiding the internal details** and **showing only the essential features** of an object
- Helps protect internal object states from external modification
- Promotes **loose coupling** and **modular design**

| Coupling Type      | Description                                                                        | Example                                                 |
| ------------------ | ---------------------------------------------------------------------------------- | ------------------------------------------------------- |
| **Tight Coupling** | A class is **heavily dependent** on another class's concrete implementation        | One class creates and uses another directly             |
| **Loose Coupling** | A class **depends on an interface or abstraction**, not on specific implementation | One class uses an **interface** to interact with others |

| Feature          | Interface                                                     | Abstract Class                          |
| ---------------- | ------------------------------------------------------------- | --------------------------------------- |
| Inheritance      | Multiple                                                      | Single                                  |
| Implementation   | No implementation (until C# 8)                                | Can have full or partial implementation |
| Constructors     | ❌ Not allowed                                                 | ✅ Allowed                               |
| Fields           | ❌ Not allowed                                                 | ✅ Allowed                               |
| Access Modifiers | Implicitly public                                             | Can be public, private, protected, etc. |
| Use Case         | When many unrelated classes need to implement common behavior | When classes share base implementation  |

## Indexers
- **Indexer** allows an object to be indexed **like an array**, using the square bracket (`[]`) syntax
- This is especially useful when a class encapsulates a collection, such as a list or array, and you want to expose element-like access to its items
- An **indexer** looks like a property, but it takes **parameters** (usually an index) and allows objects of a class to be accessed **like arrays**
- The keyword `this` is used to define the indexer
- You can overload indexers with multiple parameters 
- Indexers can have `get`, `set`, or both, just like properties

## Array
- **Array** is a **collection of variables** (all of the same type) that are stored in **contiguous memory locations**
- Arrays let you store multiple values in a single variable, instead of declaring separate variables for each value
- In **Jagged Arrays**, each row can have a different size

```C#
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

int[,] matrix = new int[2,3] {
    {1, 2, 3},
    {4, 5, 6}
};

int[][] jagged = new int[2][];
jagged[0] = new int[] { 1, 2 };
jagged[1] = new int[] { 3, 4, 5 };
```

| Method/Property             | Description                          | Example                               |
| --------------------------- | ------------------------------------ | ------------------------------------- |
| `Length`                    | Number of elements in array          | nums.Length                           |
| `Rank`                      | Number of dimensions                 | nums.Rank                             |
| `GetLength(d)`              | Length of specific dimension         | matrix.GetLength(0)<br>               |
| `GetValue()` / `SetValue()` | Access or assign value via index     | nums.GetValue(1) nums.SetValue(10, 0) |
| `IndexOf()`                 | First index of a value               | Array.IndexOf(nums, 2);               |
| `LastIndexOf()`             | Last index of a value                | Array.LastIndexOf(nums, 2);           |
| `Sort()`                    | Sorts array in ascending order       | Array.Sort(nums)                      |
| `Reverse()`                 | Reverses array elements              | Array.Reverse(nums)                   |
| `Copy()`                    | Copies elements between arrays       | Array.Copy(nums, copy, 3)             |
| `Clone()`                   | Creates a shallow copy               | original.Clone()                      |
| `Clear()`                   | Resets elements to default           | Array.Clear(nums, 1, 2)               |
| `Exists()`                  | Checks if any item matches condition | Array.Exists(nums, n=>n%2=0)          |
| `Find()`                    | Gets first matching item             | Array.Find(nums, condition)           |
| `FindAll()`                 | Gets all matching items              | Array.FindAll(nums, condition)        |
| `FindIndex()`               | Gets index of first matching item    | Array.FindIndex(nums, condition)      |
| `TrueForAll()`              | Checks if all items match condition  | Array.TrueForAll(nums, condition)     |
## Collections
- **Collections** are **classes** that are used to store, manage, and manipulate **groups of related objects**
- Dynamic sizing (unlike arrays)
* Built-in methods for searching, sorting, and manipulation
* Better performance and safety (especially generics)
- C# collections fall into three main categories
### I. **Non-Generic Collections** (System.Collections)
* Can store **any type of object** (boxed as `object`)
* Mixing of types
* Boxing and Unboxing 
* Less type-safe and slower due to boxing/unboxing
	* `ArrayList`
	* `Hashtable` 
	* `Stack`
	* `Queue`

```csharp
ArrayList list = new ArrayList();
list.Add(10);
list.Add("hello"); // No type checking
```

- **No type safety** : everything is `object`, so casting is needed
- **Boxing/unboxing** : occurs with value types
- **Unordered** : does not maintain the order of items
- **Not recommended** for new code 
#### Boxing and Unboxing
- C# separates **value types** (like `int`, `double`, `bool`, `struct`) from **reference types** (like `object`, `string`, `class` instances)
- **Boxing** is the process of converting a **value type** to an **object**
- **Unboxing** is converting an **object** back to a **value type**

### 1. ArrayList
- It is a **dynamically sized array**, meaning it can grow or shrink as needed
- Can store mixed types and allows duplicates

| Method / Property       | Description                                              |
| ----------------------- | -------------------------------------------------------- |
| `Add(object item)`      | Adds an element to the end of the list                   |
| `AddRange(ICollection)` | Adds a collection of items                               |
| `Insert(index, item)`   | Inserts item at specified index                          |
| `Remove(object)`        | Removes the first occurrence of an object                |
| `RemoveAt(index)`       | Removes the item at the given index                      |
| `Clear()`               | Removes all elements                                     |
| `Contains(object)`      | Checks if an item exists.                                |
| `Count`                 | Returns the number of items                              |
| `Sort()`                | Sorts elements (all must be of the same comparable type) |
* Boxing creates **heap allocation**
* Unboxing incurs **type casting** and **runtime checks**
* These steps add **performance overhead** and **risk runtime errors**
* Recommended Alternative: Use `List<T>`

```csharp
ArrayList list = new ArrayList();
list.Add(42);             // Boxing occurs
int num = (int)list[0];   // Unboxing occurs
```
### 2. Hashtable
- It stores **key-value pairs** where the **key is unique**, and **both key and value are of type `object`**

| Method / Property  | Description                          |
| ------------------ | ------------------------------------ |
| `Add(key, value)`  | Adds a key-value pair                |
| `Remove(key)`      | Removes entry with the specified key |
| `Clear()`          | Removes all elements                 |
| `ContainsKey(key)` | Returns true if key exists           |
| `Contains(value)`  | Returns true if value exists         |
| `Count`            | Returns number of items              |
| `Keys`             | Gets all keys                        |
| `Values`           | Gets all values                      |
| `ht[key]`          | Gets or sets value by key            |
```C#
using System.Collections;

class Program{
    static void Main(){
        Hashtable employeeTable = new Hashtable();

        // Add key-value pairs
        employeeTable.Add(101, "Alice");
        employeeTable.Add(102, "Bob");
        employeeTable.Add(103, "Charlie");

        // Accessing value by key
        Console.WriteLine(employeeTable[102]);  // Output: Bob

        // Modify value
        employeeTable[102] = "Bobby";

        // Check if a key exists
        if(employeeTable.ContainsKey(103)){
            Console.WriteLine("Employee ID 103 is present.");
        }

        // Iterate through Hashtable
        foreach (DictionaryEntry entry in employeeTable){
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }

        // Remove a key
        employeeTable.Remove(101);
        Console.WriteLine("After removal, Count: " + employeeTable.Count);
    }
}
```

### 3. Stack
- A **`Stack`** is a **Last-In-First-Out (LIFO)** collection in C#
- C# provides two versions
	- **Non-generic**: `System.Collections.Stack`
	- **Generic**: `System.Collections.Generic.Stack<T>` 

| Method / Property | Description                          |
| ----------------- | ------------------------------------ |
| `Push(item)`      | Adds an item to the top              |
| `Pop()`           | Removes and returns the top item     |
| `Peek()`          | Returns top item without removing it |
| `Contains(item)`  | Checks if item exists                |
| `Clear()`         | Removes all elements                 |
| `Count`           | Returns number of elements           |
| `ToArray()`       | Converts stack to array              |
```C#
using System.Collections;
using System.Collections.Generic;

class Program{
    static void Main(){
	    Stack myStack = new Stack(); // Non-Generic Stack

        myStack.Push(10);              // int
        myStack.Push("Hello");         // string
        myStack.Push(3.14);            // double

        Console.WriteLine("Top: " + myStack.Peek());  // 3.14
        Console.WriteLine("Popped: " + myStack.Pop());  // 3.14

        foreach (var item in myStack){
            Console.WriteLine("Item: " + item);
        }

        // Cast if needed
        string str = (string)myStack.Pop();  // Hello
        Console.WriteLine("Casted string: " + str);
        
        Stack<string> browserHistory = new Stack<string>(); // Generic Stack

        browserHistory.Push("google.com");
        browserHistory.Push("stackoverflow.com");
        browserHistory.Push("github.com");

        Console.WriteLine("Current page: " + browserHistory.Peek());  // github.com

        Console.WriteLine("Going back from: " + browserHistory.Pop());  // github.com

        foreach (string url in browserHistory){
            Console.WriteLine("Visited: " + url);
        }

        Console.WriteLine("History count: " + browserHistory.Count);
    }
}
```

### 4. Queue
- A **Queue** is a **First-In-First-Out (FIFO)** collection
- C# provides two types of `Queue`
	1. **Non-Generic Queue**: `System.Collections.Queue`
	2. **Generic Queue**: `System.Collections.Generic.Queue<T>`

| Method/Property         | Description                                |
| ----------------------- | ------------------------------------------ |
| `Enqueue(object item)`  | Adds an item to the queue                  |
| `Dequeue()`             | Removes and returns the first item         |
| `Peek()`                | Returns the first item without removing it |
| `Contains(object item)` | Checks if item exists                      |
| `Clear()`               | Removes all items                          |
| `Count`                 | Returns the number of items                |
```csharp
using System.Collections;
using System.Collections.Generic;

class Program{
    static void Main(){
	    Queue myQueue = new Queue(); // Non-Generic
	    myQueue.Enqueue("John");
        myQueue.Enqueue(42);
        myQueue.Enqueue(3.14);

        Console.WriteLine("Peek: " + myQueue.Peek());  // John
        Console.WriteLine("Dequeue: " + myQueue.Dequeue());  // John
        
        foreach (var item in myQueue){
            Console.WriteLine("Item: " + item);
        }
        
        Queue<string> queue = new Queue<string>(); // Generic
        queue.Enqueue("Alice");
        queue.Enqueue("Bob");
        queue.Enqueue("Charlie");
        Console.WriteLine("Peek: " + queue.Peek());  // Alice
        Console.WriteLine("Dequeue: " + queue.Dequeue());  // Alice

        foreach (var item in queue){
            Console.WriteLine("Item: " + item);
        }
    }
}
```

### II. **Generic Collections** (System.Collections.Generic) 
* Store **specific types**, improving **performance and type safety**
	* `List<T>`
	* `Dictionary<TKey, TValue>`
	* `Queue<T>`
	* `Stack<T>`
	* `HashSet<T>`
### 1. List
- **List** is a part of the `System.Collections.Generic` namespace and provides a **dynamic array**
```csharp
List<int> numbers = new List<int>(); // Empty list
numbers.Add(10);
numbers.Add(20);
List<string> names = new List<string> { "Alice", "Bob" }; // Initialized list
```

- It grows or shrinks as needed. Unlike regular arrays, a `List<T>` doesn’t need a fixed size and gives you powerful methods to work with collections of data

```C#
using System.Collections.Generic;
// List<int> numbers = new List<int>();

List<int> numbers = new List<int> { 1, 2, 3, 4 };

numbers.Add(5); // List: {1, 2, 3, 4, 5}
numbers.AddRange(new int[] { 6, 7 });  // {1, 2, 3, 4, 5, 6, 7}
numbers.Insert(2, 99);  // {1, 2, 99, 3, 4, ...}
numbers.InsertRange(2, new int[] { 100, 200 });
numbers.Remove(99);
numbers.RemoveAt(2);
numbers.RemoveRange(2, 3);
numbers.Clear();
bool hasThree = numbers.Contains(3);
int idx = numbers.IndexOf(4);
int lastIdx = numbers.LastIndexOf(4);
numbers.Sort();
numbers.Reverse();
int[] arr = numbers.ToArray();
int result = numbers.Find(x => x > 3);
List<int> evens = numbers.FindAll(x => x % 2 == 0);
int idx = numbers.FindIndex(x => x > 5);
bool found = numbers.Exists(x => x == 10);
bool allPositive = numbers.TrueForAll(x => x > 0);
numbers.ForEach(x => Console.WriteLine(x));
List<int> sublist = numbers.GetRange(1, 3);

int[] arr = new int[numbers.Count];
numbers.CopyTo(arr);
```

| Method/Property                             | Description                           |
| ------------------------------------------- | ------------------------------------- |
| `Add()` / `AddRange()`                      | Add single/multiple items             |
| `Insert()` / `InsertRange()`                | Insert items at index                 |
| `Remove()` / `RemoveAt()` / `RemoveRange()` | Remove items                          |
| `Clear()`                                   | Remove all items                      |
| `Contains()`                                | Check if item exists                  |
| `IndexOf()` / `LastIndexOf()`               | Get index of items                    |
| `Sort()` / `Reverse()`                      | Sort or reverse list                  |
| `Find()` / `FindAll()` / `FindIndex()`      | Search with condition                 |
| `Exists()` / `TrueForAll()`                 | Check condition match                 |
| `ForEach()`                                 | Apply an action to each item          |
| `GetRange()`                                | Get a part of the list                |
| `ToArray()` / `CopyTo()`                    | Convert or copy to array              |
| `Count` / `Capacity`                        | Size and storage capacity of the list |
### 2. Dictionary
| Method / Property           | Description                             |
| --------------------------- | --------------------------------------- |
| `Add(key, value)`           | Adds a new key-value pair               |
| `Remove(key)`               | Removes the pair with the specified key |
| `ContainsKey(key)`          | Checks if the key exists                |
| `ContainsValue(value)`      | Checks if the value exists              |
| `TryGetValue(key, out val)` | Efficiently gets value if key exists    |
| `Count`                     | Gets the number of key-value pairs      |
| `Clear()`                   | Removes all items                       |
| `Keys`                      | Gets a collection of keys               |
| `Values`                    | Gets a collection of values             |
```C#
using System.Collections.Generic;

class Program{
    static void Main(){
        Dictionary<int, string> students = new Dictionary<int, string>();

        students.Add(1, "Alice");
        students.Add(2, "Bob");
        students[3] = "Charlie";  

        Console.WriteLine("Student with ID 1: " + students[1]);

        if (students.ContainsKey(2)){
            Console.WriteLine("ID 2 exists.");
        }

        students.Remove(3);

        foreach (var pair in students){
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }

        if (students.TryGetValue(1, out string name)){
            Console.WriteLine("Name found: " + name);
        }
    }
}
```

### 5. HashSet
- It is **unordered** and **does not allow duplicates**
- Unorderd: The elements are **not stored in the order you add them**
- Internally uses a **hash table** for **fast lookup and insert** operations, so the items are arranged based on their **hash codes**, not insertion order

| Method / Property               | Description                                  |
| ------------------------------- | -------------------------------------------- |
| `Add(T item)`                   | Adds an item if it’s not already in the set  |
| `Remove(T item)`                | Removes the item if found                    |
| `Contains(T item)`              | Returns `true` if the item exists            |
| `Count`                         | Returns the number of elements               |
| `Clear()`                       | Removes all elements                         |
| `UnionWith(IEnumerable<T>)`     | Adds all elements from another collection    |
| `IntersectWith(IEnumerable<T>)` | Keeps only elements that exist in both sets  |
| `ExceptWith(IEnumerable<T>)`    | Removes elements that exist in another set   |
| `SetEquals(IEnumerable<T>)`     | Checks if two sets contain the same elements |
| `IsSubsetOf(IEnumerable<T>)`    | Checks if the current set is a subset        |
| `IsSupersetOf(IEnumerable<T>)`  | Checks if it’s a superset                    |
```C#
using System.Collections.Generic;

class Program{
    static void Main(){
        HashSet<string> fruits = new HashSet<string>();

        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Orange");

        bool added = fruits.Add("Apple");  
        Console.WriteLine("Added again? " + added);  

        if (fruits.Contains("Banana")){
            Console.WriteLine("Banana is in the set.");
        }

        fruits.Remove("Orange");
        
		// Output may in any order - Unordered
        foreach (var fruit in fruits){
            Console.WriteLine("Fruit: " + fruit);
        }
		
		HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4 };
		HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6 };
		set1.ExceptWith(set2);     // set1 = {1, 2}
		set1.UnionWith(set2);      // set1 = {1, 2, 3, 4, 5, 6}
		set1.IntersectWith(set2);  // set1 = {3, 4}
    }
}
```

### III. **Concurrent Collections** (System.Collections.Concurrent)
* Designed for **thread-safe operations** in multi-threaded apps
	* `ConcurrentDictionary<TKey, TValue>`
	* `ConcurrentQueue<T>`
	* `BlockingCollection<T>`

```csharp
ConcurrentQueue<string> queue = new ConcurrentQueue<string>();
queue.Enqueue("Task1");
```

### 1. Dictionary
- `ConcurrentDictionary<TKey, TValue>` is a **thread-safe**, generic collection in C# designed to allow **multiple threads to safely read and write** without requiring explicit locks
- In multi-threaded environments, collections like `Dictionary<TKey, TValue>` can lead to race conditions or exceptions if accessed concurrently
- `ConcurrentDictionary` solves this by managing internal locking automatically
- You can safely use `ConcurrentDictionary` across **multiple threads** without worrying about
	- Data corruption
	- Manual `lock` usage
	- Performance bottlenecks

| Method                                   | Description                                                     |
| ---------------------------------------- | --------------------------------------------------------------- |
| `TryAdd(key, value)`                     | Adds a key/value if the key doesn’t exist                       |
| `TryRemove(key, out value)`              | Removes a key/value pair safely                                 |
| `TryUpdate(key, newValue, oldValue)`     | Updates the value if the old value matches                      |
| `GetOrAdd(key, value)`                   | Adds key/value if key doesn't exist; otherwise returns existing |
| `AddOrUpdate(key, addValue, updateFunc)` | Adds or updates value atomically                                |
```C#
using System.Collections.Concurrent;

class Program{
    static void Main(){
	    // ConcurrentDictionary<int, string> dict = new ConcurrentDictionary<int, string>()
        var employees = new ConcurrentDictionary<int, string>();

        employees.TryAdd(101, "Alice");
        employees.TryAdd(102, "Bob");

        string emp = employees.GetOrAdd(103, "Charlie"); // Adds Charlie
        employees.AddOrUpdate(104, "John", (key, oldValue) => oldValue + 1 ) // Adds { 104 : John }
        employees.AddOrUpdate(104, "John Wick", (key, oldValue) => oldValue + 1 ) // Updates { 104 : John Wick }

        employees.TryUpdate(101, "Alicia", "Alice"); // Changes Alice to Alicia

        employees.TryRemove(102, out string removedEmp);
        Console.WriteLine("Removed: " + removedEmp);

        foreach (var pair in employees){
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
```

## Problem with Regular Dictionary in Multithreading
- A regular `Dictionary<TKey, TValue>` is **not thread-safe**
- **Thread A** is adding a key at the same time that
- **Thread B** is removing or reading a key
- This can lead to:
	- **Data corruption** (invalid internal structure)
	- **Runtime exceptions** like `InvalidOperationException`
	- You need to use `lock` to protect access manually
- `ConcurrentDictionary<TKey, TValue>` is designed to **handle multiple threads safely**, without you writing manual `lock` code
	- Divides the dictionary into **segments** (like buckets)
	- Uses **fine-grained locking**, only locking small parts as needed
	- Allows **multiple threads** to read/write with **minimal blocking**

```C#
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Program{
    static void Main(){
        var loggedInUsers = new ConcurrentDictionary<int, string>();

        // Simulate concurrent logins
        Parallel.For(1, 6, userId =>{
            string username = $"User{userId}";
            bool added = loggedInUsers.TryAdd(userId, username);
            Console.WriteLine(added
                ? $"{username} logged in"
                : $"{username} login failed");
        });

        // Simulate concurrent logouts
        Parallel.For(1, 4, userId =>{
            if (loggedInUsers.TryRemove(userId, out string removedUser)){
                Console.WriteLine($"{removedUser} logged out");
            }
        });

        Console.WriteLine("\nFinal Logged-In Users:");
        foreach (var l in loggedInUsers){
            Console.WriteLine($"ID: {l.Key}, Username: {l.Value}");
        }
    }
}
```

### 2. Concurrent Queue
- `ConcurrentQueue<T>` is a **generic**, **lock-free**, **thread-safe** queue
- Multiple threads can **enqueue** and **dequeue** without explicit locking
- It is optimised for **multi-threaded environments**

| Method                     | Description                                        |
| -------------------------- | -------------------------------------------------- |
| `Enqueue(T item)`          | Adds an item to the end                            |
| `TryDequeue(out T result)` | Removes and returns the item at the beginning      |
| `TryPeek(out T result)`    | Returns the item at the beginning without removing |
| `Count`                    | Gets the number of items                           |
| `Clear()`                  | Removes all items                                  |
| `ToArray()`                | Returns a snapshot of the queue as an array        |
```C#
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Program{
    static void Main(){
        var queue = new ConcurrentQueue<string>();

        // Simulate multiple threads enqueuing
        Parallel.For(1, 6, i => {
            queue.Enqueue($"Task{i}");
            Console.WriteLine($"Enqueued: Task{i}");
        });
        
        if(queue.TryPeek(out string front)){
            Console.WriteLine($"\nCurrent Task : {front}");
        }

        Console.WriteLine("\nDequeuing...");
        // Dequeue all items (single thread)
        while (queue.TryDequeue(out string task)){
            Console.WriteLine($"Processed: {task}");
        }
        Console.WriteLine($"\nRemaining in queue: {queue.Count}");
    }
}
```

# LINQ (Language Integrated Query)
- A powerful feature that allows querying collections (like arrays, lists, databases, XML, etc.) using SQL-like syntax directly in C# code
- LINQ allows you to write queries in a declarative style to manipulate data from various sources: **in-memory objects**, **databases**, **XML documents**, etc.
- Before LINQ, querying data meant:
	- SQL for databases 
	- XPath/XSLT for XML
	- Loops and conditions for collections
- Now, LINQ provides
	- **Consistent querying** for all types
	- **Compile-time syntax checking**
	- **IDE IntelliSense** support
	- **Strong typing** and **performance optimization**
- Two types of LINQ syntax:
	- **Query Syntax** (similar to SQL)
	- **Method Syntax** (uses lambda expressions and method chaining)
- Official Microsoft Docs: [https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)

| Operation                                                | Description                    | Example                         |
| -------------------------------------------------------- | ------------------------------ | ------------------------------- |
| `Where` , `OfType`                                       | Filter elements                | `Where(x => x > 5)`             |
| `Select` , `SelectMany`                                  | Projection (selecting columns) | `Select(x => x.Name)`           |
| `OrderBy` , `ThenBy`                                     | Sort ascending                 | `OrderBy(x => x.Age)`           |
| `OrderByDescending`                                      | Sort descending                | `OrderByDescending(x => x.Age)` |
| `GroupBy` , `ToLookup`                                   | Group elements                 | `GroupBy(x => x.Category)`      |
| `Join` , ``GroupJoin``                                   | Join two collections           | `Join(...)`                     |
| `Any`/`All` , ``Contains``                               | Existential checks             | `Any(x => x.Age > 30)`          |
| `First`/`FirstOrDefault`                                 | Get first element              | `First(x => x.Id == 1)`         |
| `Count`, `Sum`, `Min`, `Max`, `Average`                  | Aggregates                     |                                 |
| `First`, `FirstOrDefault`, `Single`, `Last`, `ElementAt` | Element                        |                                 |
| `Distinct`, `Union`, `Intersect`, `Except`               | Set                            |                                 |
| `ToList`, `ToArray`, `ToDictionary`                      | Conversion                     |                                 |
- Make sure `.OfType<T>()` is used **only on a collection** like `List<object>`, `ArrayList`, or similar

```C#
// LINQ to XML
XDocument doc = XDocument.Load("employees.xml");

var employees = from emp in doc.Descendants("Employee")
                where (int)emp.Element("Age") > 30
                select new {
                    Name = emp.Element("Name")?.Value,
                    Age = emp.Element("Age")?.Value
                };

foreach (var e in employees)
    Console.WriteLine($"{e.Name} - {e.Age}");
```

- **Deferred Execution**: Query is not executed until it's enumerated (`foreach`, `ToList()`, etc.)
- **Immediate Execution**: When methods like `ToList()`, `Count()`, etc., are called

```C#
var result = nums.Where(n => n > 10); // Not yet executed
var list = result.ToList(); // Executed here
```

**GroupBy**
- `GroupBy` is used to **group elements in a collection based on a key**
- The result is a sequence of groups, where each group has a `Key` and a list of items that match that key

```C#
var groupedM = collection.GroupBy(item => item.KeyProperty);
var groupedQ = from item in collection
              group item by item.KeyProperty;
```

**ToLookup**
- `ToLookup` is like `GroupBy`, but it **immediately executes** and returns a **lookup (like a dictionary)** where a key maps to a group of elements
- Unlike `GroupBy`, `ToLookup` returns an object of type `ILookup<TKey, TElement>`, and **does not support query syntax** - only **method syntax** is available