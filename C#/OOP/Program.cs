namespace One{
    class Car{
        public string brand;
        public int speed;

        public void drive(){
            Console.WriteLine($"{brand} is driving at {speed} km/h");
        }
    }
}

namespace Two{
    class Car{
        public string brand;
        public int speed;

        public Car(){
            brand = "Unknown";
            speed = 0;
            Console.WriteLine($"{brand} is driving at {speed} km/h");
        }

        public void drive(){
            Console.WriteLine($"{brand} is driving at {speed} km/h");
        }
    }
}

namespace Three{
    class Car{
        public string brand;
        public int speed;

        public Car(string carBrand, int carSpeed){
            brand = carBrand;
            speed = carSpeed;
        }

        public void drive(){
            Console.WriteLine($"{brand} is driving at {speed} km/h");
        }
    }
}

namespace Four{
    public class Car{
        public string brand;
        public int speed;

        public Car(){
            brand = "Unknown";
            speed = 0;
        }

        public Car(string brand){
            this.brand = brand;
            speed = 100; 
        }

        public Car(string brand, int speed){
            this.brand = brand;
            this.speed = speed;
        }

        public void drive(){
            Console.WriteLine($"{brand} is driving at {speed} km/h");
        }
    }
}

namespace privateConstructor{
    public class Car{
        private static Car obj;
        // Private constructor to prevent external instantiation
        private Car(){}
        // Singleton getInstance method
        public static Car getInstance(){
            if(obj == null){
                obj = new Car();
            }
            return obj;
        }

        public void drive(string msg){
            Console.WriteLine("Message: " + msg);
        }
    }
}

class OOP{
    static void Main(){
        One.Car obj1 = new One.Car();
        obj1.brand = "Toyota";
        obj1.speed = 60;
        obj1.drive();

        Two.Car obj2 = new Two.Car();
        obj2.brand = "Hundai";
        obj2.speed = 80;
        obj2.drive();

        Three.Car obj3 = new Three.Car("Suzuki", 70);
        obj3.drive();

        Four.Car c1 = new Four.Car();                 
        Four.Car c2 = new Four.Car("Honda");          
        Four.Car c3 = new Four.Car("Audi", 180);      
        c1.drive(); 
        c2.drive(); 
        c3.drive(); 

        // Get singleton instances
        privateConstructor.Car car1 = privateConstructor.Car.getInstance();
        privateConstructor.Car car2 = privateConstructor.Car.getInstance();
        car1.drive("Private Constructor Car1");
        car2.drive("Private Constructor Car2");
        Console.WriteLine("car1 and car2 same: " + (car1 == car2));
    }
}