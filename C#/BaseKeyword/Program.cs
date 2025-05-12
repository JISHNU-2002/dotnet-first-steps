namespace One{
    class Animal{
        public void Eat(){
            Console.WriteLine("Animal is eating");
        }
    }

    class Dog : Animal{
        public void Eat(){
            Console.WriteLine("Dog is eating");
            base.Eat(); // Calls Animal.Eat()
        }
    }
}

namespace Two{
    class Animal{
        public Animal(string name){
            Console.WriteLine("Animal constructor called with name: " + name);
        }
    }

    class Dog : Animal{
        public Dog() : base("Tommy"){
            Console.WriteLine("Dog constructor called");
        }
    }
}


class Program{
    static void Main(){
        One.Dog d = new One.Dog();
        d.Eat();

        Two.Dog e = new Two.Dog();
    }
}