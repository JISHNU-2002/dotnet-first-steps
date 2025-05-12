int a = 7; 
int b = 4; 
int c = 3; 
int d = (a + b) / c; 
int e = (a + b) % c; 
Console.WriteLine($"quotient: {d}"); 
Console.WriteLine($"remainder: {e}");

int maxI = int.MaxValue; 
int minI = int.MinValue; 
Console.WriteLine($"The range of integers is {minI} to {maxI}");

int what = maxI + 3; 
Console.WriteLine($"An example of overflow: {what}");

double f = 5;
double g = 4; 
double h = 2; 
double i = (f + g) / h; 
Console.WriteLine(i);

double maxD = double.MaxValue; 
double minD = double.MinValue; 
Console.WriteLine($"The range of double is {minD} to {maxD}");

decimal minDec = decimal.MinValue; 
decimal maxDec = decimal.MaxValue; 
Console.WriteLine($"The range of the decimal type is {minDec} to {maxDec}");

/* The M suffix on the numbers is how you indicate that a constant should use the decimal type
Otherwise, the compiler assumes the double type*/
double ad = 1.0; double bd = 3.0; Console.WriteLine(ad / bd); 
decimal cd = 1.0M; decimal dd = 3.0M; Console.WriteLine(cd / dd);

double r = 2.50;
double area = Math.PI*r*r;
Console.WriteLine("Area of the circle: " + area);