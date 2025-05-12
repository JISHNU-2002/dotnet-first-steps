namespace InterfaceA{
    interface IVehicle{
        void Drive();
        void Stop();
    }

    class Car : IVehicle{
        public void Drive(){
            Console.WriteLine("Car is driving");
        }

        public void Stop(){
            Console.WriteLine("Car has stopped");
        }
    }
}

namespace Aclass{
    abstract class Animal{
        public abstract void MakeSound(); // Abstract method

        public void Sleep(){ // Concrete method
            Console.WriteLine("Animal is sleeping");
        }
    }

    class Dog : Animal{
        public override void MakeSound(){
            Console.WriteLine("Dog barks");
        }
    }
}

namespace Both{
    interface IMovable{
        void Move();
    }

    abstract class Vehicle : IMovable{
        public abstract void Move();

        public void Fuel(){
            Console.WriteLine("Fueling vehicle...");
        }
    }

    class Bike : Vehicle{
        public override void Move(){
            Console.WriteLine("Bike is moving...");
        }
    }
}

class Program{
    static void Main(){
        InterfaceA.IVehicle vehicle = new InterfaceA.Car();
        vehicle.Drive();  // Output: Car is driving
        vehicle.Stop();   // Output: Car has stopped

        Aclass.Animal myDog = new Aclass.Dog();
        myDog.MakeSound();  // Output: Dog barks
        myDog.Sleep();      // Output: Animal is sleeping

        
        Both.IMovable mov = new Both.Bike();
        mov.Move(); // Output: Bike is moving...

        Both.Vehicle veh = new Both.Bike();
        veh.Fuel(); // Output: Fueling vehicle...
    }
}
