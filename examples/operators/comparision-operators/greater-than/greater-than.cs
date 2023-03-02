using System;

class Program
{
    static void Main()
    {
        // Let's compare a few different values.
        int number1 = 10;
        int number2 = 255;
        float number3 = 255.001f;

        // We can compare variables to literals.
        Console.WriteLine($"Is {number1} greater than {9}? {number1 > 9}.");
        Console.WriteLine($"Is {number1} greater than {10}? {number1 > 10}.");
        
        // We can compare variables to other variables. This is very useful!
        Console.WriteLine($"Is {number1} greater than {number2}? {number1 > number2}.");
        
        // Let's compare an integer to a float.
        // Since any integer is a valid float, C# will implicitely convert the int
        // to a float for the comparison.
        Console.WriteLine($"Is {number2} greater than {number3}? {number2 > number3}.");
    }
}