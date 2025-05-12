void Greet(){
    Console.WriteLine("Hello, welcome to C#!");
}

void PrintName(string name){
    Console.WriteLine("Your name is " + name);
}

int GetNumber(){
    return 42;
}

int Add(int a, int b){
    return a + b;
}

Greet();                      // calls method #1
PrintName("Deadpool");        // calls method #2
int value = GetNumber();      // calls method #3
Console.WriteLine(value);     
int sum = Add(5, 10);         // calls method #4
Console.WriteLine(sum);


// Method Overloading
void Add(int a, int b){
    Console.WriteLine( a + b );
}
void Add(int a, int b, int c){
    Console.WriteLine( a + b + c );
}

Add(1,2);
Add(1,2,3)