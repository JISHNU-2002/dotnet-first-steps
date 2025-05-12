// Record type
public record Point(int X, int Y);

public class Program{
    public static void Main(){
        Point pt1 = new Point(1, 1);
        var pt2 = pt1 with { Y = 10 };
        Console.WriteLine($"The two points are {pt1} and {pt2}");
    }
}