namespace Single{
    class Animal{
        public void Eat(){
            Console.WriteLine("Animal eats");
        }
    }

    class Dog : Animal{
        public void Bark(){
            Console.WriteLine("Dog barks");
        }
    }
}

namespace MultiLevel{
    class Animal{
        public void Eat(){
            Console.WriteLine("Animal eats");
        }
    }

    class Dog : Animal{
        public void Bark(){
            Console.WriteLine("Dog barks");
        }
    }

    class Puppy : Dog{
        public void Weep(){
            Console.WriteLine("Puppy weeps");
        }
    }
}

namespace Hierarchical{
    class Animal{
        public void Eat(){
            Console.WriteLine("Animal eats");
        }
    }

    class Dog : Animal{
        public void Bark(){
            Console.WriteLine("Dog barks");
        }
    }

    class Cat : Animal{
        public void Meow(){
            Console.WriteLine("Cat meows");
        }
    }
}

namespace Multiple{
    interface IAnimal{
        void Eat();
    }

    interface IPet{
        void Play();
    }

    class Dog : IAnimal, IPet{
        public void Eat(){
            Console.WriteLine("Dog eats");
        }

        public void Play(){
            Console.WriteLine("Dog plays");
        }
    }
}

namespace Hybrid{
    interface IAnimal{
        void Eat();
    }

    class Animal{
        public void Sleep(){
            Console.WriteLine("Animal sleeps");
        }
    }

    class Dog : Animal, IAnimal{
        public void Eat(){
            Console.WriteLine("Dog eats");
        }
    }
}

class Inheritance{
    static void Main(){
        Single.Dog d = new Single.Dog();
        d.Eat();   
        d.Bark();

        MultiLevel.Puppy p = new MultiLevel.Puppy();
        p.Eat();  
        p.Bark(); 
        p.Weep();

        Hierarchical.Dog dog = new Hierarchical.Dog();
        dog.Eat();
        dog.Bark();
        Hierarchical.Cat c = new Hierarchical.Cat();
        c.Eat();
        c.Meow();

        Multiple.Dog obj = new Multiple.Dog();
        obj.Eat();
        obj.Play();

        Hybrid.Dog hybrid = new Hybrid.Dog();
        hybrid.Sleep(); 
        hybrid.Eat();   
    }
}