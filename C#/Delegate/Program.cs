using System.Linq;

// 1. Delegate declaration
// public delegate T Operation<T>(T x, T y);
public delegate int Operation(int num1, int num2);
public delegate void Notify();
public delegate int Calculate(int x);

// 2. Class with methods

// Simple delegate methods
class Methods{
    public static int add(int num1, int num2) => num1 + num2;
    public static int mul(int num1, int num2) => num1 * num2;
}

// Multicasting
class MultiCast{
    public static void step1() => Console.WriteLine("\nstep1");
    public static void step2() => Console.WriteLine("step2");
    public static int methodA(int x){
        Console.WriteLine("\nMethodA initial value: "+ x);
        return x+1;
    }
    public static int methodB(int x){
        Console.WriteLine("MethodB initial value: "+ x);
        return x+2;
    }
}

// Built-in delegate methods
class BuiltIn{
    public BuiltIn(){
        Console.WriteLine("\nBuilt-in Delegate Methods : Action - Func - Predicate");
        Action greet = () => Console.WriteLine("Hello World");
        greet();

        Action<string> wel = name => Console.WriteLine("Welcome "+ name);
        wel("Jishnu");

        Func<int, int, int> add = (num1, num2) => num1+num2;
        Console.WriteLine("Sum : "+ add(1,2));

        Predicate<int> isEven = num => num % 2 == 0;
        Console.WriteLine(isEven(5));
    }
}

// 3. Using delegate
class Program{
    static void Main(){
        Operation obj1 = new Operation(Methods.add);
        Operation obj2 = Methods.mul;

        Console.WriteLine(obj1(3, 4)); 
        Console.WriteLine(obj2(3, 4));

        Notify obj3 = MultiCast.step1;
        obj3 += MultiCast.step2;
        obj3();

        Calculate obj4 = MultiCast.methodA;
        obj4 += MultiCast.methodB;
        int num = obj4(5); // // Calls MethodA and then MethodB
        Console.WriteLine("Final value: "+ num); // Only methodB's return value will be stored

        Func<int, int> calc = MultiCast.methodA;
        calc += MultiCast.methodB;
        int rt = calc(5); // Return value is from MethodB
        Console.WriteLine("Final value: "+ rt);

        // To calculate each result in multicast - return values
        // Method 1
        Console.WriteLine("MultiCast Calculate with individual results");
        Calculate obj5 = MultiCast.methodA;
        obj5 += MultiCast.methodB;
        char i = 'A';
        // foreach(Delegate d in obj5.GetInvocationList()){
        foreach(var d in obj5.GetInvocationList()){
            int result = ((Calculate)d)(5);
            Console.WriteLine($"Return from method{i++}: {result}");
        }

        // Method 2
        int[] res = obj5.GetInvocationList().Select(d => ((Calculate)d).Invoke(5)).ToArray();
        for(int j=0 ; j<res.Length; j++){
            Console.WriteLine($"Return from method{j+1}: {res[j]}");
        }

        BuiltIn obj6 = new BuiltIn();
    }
}