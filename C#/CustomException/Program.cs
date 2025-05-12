using System;

public class InvalidScoreException : Exception{
    public InvalidScoreException(string msg) : base(msg) {}
}

class Program{
    // Method to set score with validation
    // An object reference is required for the non-static field, method, or property
    static void SetScore(int score){
        if (score < 0 || score > 100){
            throw new InvalidScoreException("Score must be between 0 and 100");
        }
        Console.WriteLine("Valid score: " + score);
    }

    static void Main(string[] args){
        try{
            SetScore(101);  // This will throw an exception
        }
        catch (InvalidScoreException e){
            Console.WriteLine("Caught Exception: " + e.Message);
        }
    }
}
