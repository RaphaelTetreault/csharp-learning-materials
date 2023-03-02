using System;

class Program
{
    static void Main()
    {
        // Let's compare a few different values.
        int number1 = 10;
        int number2 = 255;
        
        // We can compare variables to literals.
        bool areTheSame = number1 == 10;
        Console.WriteLine($"Is {number1} equal to {10}? {areTheSame}.");
        
        // We can compare variables to other variables. This is very useful!
        areTheSame = number1 == number2;
        Console.WriteLine($"Is {number1} equal to {number2}? {areTheSame}.");
        
        // Of course, we can compare more than numbers. In fact, we can compare
        // anything of any type with another thing of the same type.
        string text1 = "Player";
        string text2 = "PLAYER";
        areTheSame = text1 == text2;
        Console.WriteLine($"Is \"{text1}\" equal to \"{text2}\"? {areTheSame}.");
        // You will find the result is false because the strings don't share
        // the same capitalization.
        
        // What happens if we do something tricky?
        // Let's compare an integer to a float.
        float number3 = 255f;
        areTheSame = number2 == number3;
        Console.WriteLine($"Is {number2} equal to {number3}? {areTheSame}.");
        // You will find the result is true because C# implicitely converts
        // the integer into a float before being compared to 255f.
    }
}