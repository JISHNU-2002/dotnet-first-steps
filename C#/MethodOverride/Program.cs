namespace One{
    class Animal{
        public virtual void Speak(){
            Console.WriteLine("Animal speaks");
        }
    }

    class Dog : Animal{
        public override void Speak(){
            Console.WriteLine("Dog barks");
        }
    }

    class Puppy : Animal{
    public override void Speak(){
        base.Speak();                // Calls Animal.Speak()
        Console.WriteLine("Puppy barks");
    }
}

}

class Program{
    static void Main(){
        One.Animal myAnimal = new One.Dog();  // Polymorphism
        myAnimal.Speak();  // Calls Dog's Speak() because of override

        One.Puppy puppy = new One.Puppy();
        puppy.Speak();
    }
}