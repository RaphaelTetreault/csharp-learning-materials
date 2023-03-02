using System;

class Program
{
    static void Main()
    {
        // Lets have a quick look at the positive unary operator +
        int number1 = -10;
        float number2 = -33.3f;
        Console.WriteLine($"Number 1: {number1}");
        Console.WriteLine($"Number 2: {number2}");
        
        // We can invert a value by placing the - sign in front of it.
        int number3 = -number1;
        float number4 = -number1 - -number2;
        Console.WriteLine($"Number 3: {number3}");
        Console.WriteLine($"Number 4: {number4}");
    }
}