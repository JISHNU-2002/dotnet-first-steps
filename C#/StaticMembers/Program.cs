using System;
class Counter{
    public static int count = 0;  // Static field

    public Counter(){
        count++;
    }

    public static void DisplayCount(){  // Static method
        Console.WriteLine("Number of objects created: " + count);
    }
}

class Program{
    static void Main(){
        Counter.DisplayCount();  

        Counter c1 = new Counter();
        Counter c2 = new Counter();

        Counter.DisplayCount();  
    }
}
