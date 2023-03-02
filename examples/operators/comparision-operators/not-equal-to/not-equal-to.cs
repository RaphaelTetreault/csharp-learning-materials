using System;

class Program
{
    static void Main()
    {
        // Let's compare a few different values.
        int number1 = 10;
        int number2 = 255;
        
        // We can compare variables to literals.
        bool areNotTheSame = number1 != 10;
        Console.WriteLine($"Is {number1} not equal to {10}? {areNotTheSame}.");
        
        // We can compare variables to other variables. This is very useful!
        areNotTheSame = number1 != number2;
        Console.WriteLine($"Is {number1} not equal to {number2}? {areNotTheSame}.");
        
        // Of course, we can compare more than numbers. In fact, we can compare
        // anything of any type with another thing of the same type.
        string text1 = "Player";
        string text2 = "PLAYER";
        areNotTheSame = text1 != text2;
        Console.WriteLine($"Is \"{text1}\" not equal to \"{text2}\"? {areNotTheSame}.");
        // You will find the result is true because the strings don't share
        // the same capitalization.
        
        // What happens if we do something tricky?
        // Let's compare an integer to a float.
        float number3 = 255f;
        areNotTheSame = number2 != number3;
        Console.WriteLine($"Is {number2} not equal to {number3}? {areNotTheSame}.");
        // You will find the result is false because C# implicitely converts
        // the integer into a float before being compared to 255f.
    }
}