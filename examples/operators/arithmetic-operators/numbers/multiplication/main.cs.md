```csharp
using System;

class Program
{
    static void Main()
    {
        // This section uses integer math (whole numbers only)
        Console.WriteLine("Integer Math");

        // We can multiply a number by another using the '*' sign
        Console.WriteLine($"The product of 12 multiplied by 5 is '{12 * 5}'");

        // We can assign the product to a variable
        int product = 99 * 9;
        Console.WriteLine($"The product of 99 multiplied by 9 is '{product}'");

        // We can multiply many numbers in sequence.
        product = 404 * 33 * 2;
        Console.WriteLine($"The product of 404 multiplied by 33 and multiplied by 2 is '{product}'");


        // This section uses floating point math (numbers with decimal points)
        Console.WriteLine();
        Console.WriteLine("Floating Point Math");

        // We can multiply a number by another using the '*' sign
        Console.WriteLine($"The product of 12.125 multiplied by 5.366 is '{12.125f * 5.366f}'");

        // We can assign the product to a variable
        float productDecimal = 99f * 9.9f;
        Console.WriteLine($"The product of 99 multiplied by 9.9 is '{productDecimal}'");

        // We can multiply many numbers in sequence.
        productDecimal = 40.4f * 3.3f * 0.2f;
        Console.WriteLine($"The product of 40.4 multiplied by 3.3 and multiplied by 0.2 is '{product}'");
    }
}
```