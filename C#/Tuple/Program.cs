var pt1 = (X: 1, Y: 2); 
var slope = (double)pt1.Y / (double)pt1.X; 
Console.WriteLine($"A line from the origin to the point {pt1} has a slope of {slope}.");

var pt2 = pt1 with { Y = 10 }; 
Console.WriteLine($"The point 'pt1' is at {pt1}.");
Console.WriteLine($"The point 'pt2' is at {pt2}.");

var pt3 = (A: 0, B: 0);
Console.WriteLine($"The point 'pt3' is at {pt3}.");
pt3 = pt1;
Console.WriteLine($"The point 'pt3' is now at {pt3}.");





