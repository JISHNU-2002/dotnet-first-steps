using System;

namespace PropertyDemo{
    class Person{
        // 1. Full Property with Backing Field
        private string _name;
        public string Name{
            get { return _name; }
            set { _name = value; }
        }

        // 2. Auto-Implemented Property
        public int Age { get; set; }

        // 3. Read-only Property
        public string ID { get; }

        // 4. Write-only Property
        private string _password;
        public string Password{
            set { _password = value; }
        }

        // 5. Property with Validation Logic
        private int _marks;
        public int Marks{
            get { return _marks; }
            set{
                if (value >= 0 && value <= 100)
                    _marks = value;
                else
                    Console.WriteLine("Invalid marks. Must be between 0 and 100");
            }
        }

        // 6. Expression-bodied Property
        public int Square => Age * Age;

        // Constructor to set read-only property
        public Person(string id){
            ID = id;
        }

        // Show password internally (for demonstration only!)
        public void ShowPassword(){
            Console.WriteLine($"Password (private): {_password}");
        }

        // 7. Init-only Property (C# 9.0+)
        public string City { get; init; }
    }

    class Program{
        static void Main(){
            Person p = new Person("ABC123"){
                Name = "Alice",
                Age = 23,
                Marks = 95,
                City = "New York"   // init-only property (only settable here)
            };
            p.Password = "secret123";

            Console.WriteLine("Name: " + p.Name);              // Full property
            Console.WriteLine("Age: " + p.Age);                // Auto property
            Console.WriteLine("ID: " + p.ID);                  // Read-only
            Console.WriteLine("Marks: " + p.Marks);            // With validation
            Console.WriteLine("Square of Age: " + p.Square);   // Expression-bodied
            Console.WriteLine("City: " + p.City);              // Init-only
            p.ShowPassword();                                  // To show write-only property internally
            // p.City = "Chicago"; // Init-only, can't modify outside object initializer
        }
    }
}
