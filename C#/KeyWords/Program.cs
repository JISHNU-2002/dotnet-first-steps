// 'ref' Passes a variable by reference. The variable must be initialized before passing
void Square(ref int number){
    number = number * number;
}

int x = 5;
Square(ref x);
Console.WriteLine(x);  // Output: 25


/* 'out' Also passes by reference, but the variable does not need to be initialized before passing. 
Must be assigned inside the method*/
void GetValues(out int a, out int b){
    a = 10;
    b = 20;
}

int y, z;
GetValues(out y, out z);
Console.WriteLine(y + ", " + z);  // Output: 10, 20


// 'params' Allows a method to accept variable number of arguments
void PrintNumbers(params int[] numbers){
    foreach (int number in numbers)
        Console.WriteLine(number);
}

PrintNumbers(1, 2, 3, 4);  // Output: 1 2 3 4
