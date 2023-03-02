using System;

class Program
{
    static void Main()
    {
        // Lets have a quick look at the positive unary operator +
        int number1 = +10;
        float number2 = +33.3f;
        Console.WriteLine($"Number 1: {number1}");
        Console.WriteLine($"Number 2: {number2}");
        
        // You may be asking, what is the point? It does not make any apparent
        // change. This is true. There are cases where you want to use it for
        // clarity more than anything else.
        
        int number3 = +10 - +20;
        int number4 = +number1 + +number3;
        Console.WriteLine($"Number 3: {number3}");
        Console.WriteLine($"Number 4: {number4}");
    }
}