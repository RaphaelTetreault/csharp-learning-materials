```csharp
using System;

class Program
{
    static void Main()
    {
        // This section uses integer math (whole numbers only)
        Console.WriteLine("Integer Math");

        // We can get the quotient of a division by using the '/' sign
        Console.WriteLine($"The quotient of 12 divided by 5 is '{12 / 5}'");

        // We can assign the quotient to a variable
        int quotient = 99 / 9;
        Console.WriteLine($"The quotient of 99 divided by 9 is '{quotient}'");

        // We can divide many numbers in sequence
        quotient = 4000 / 300 / 20;
        Console.WriteLine($"The quotient of 4000 divided by 300 and divided by 20 is '{quotient}'");


        // This section uses floating point math (numbers with decimal points)
        Console.WriteLine();
        Console.WriteLine("Floating Point Math");

        // We can divide a number by another using the '/' sign
        Console.WriteLine($"The quotient of 12 divided by 5 is '{12f / 5f}'");

        // We can assign the quotient to a variable
        float quotientDecimal = 99f / 9f;
        Console.WriteLine($"The quotient of 99 divided by 9 is '{quotientDecimal}'");

        // We can divide many numbers in sequence
        quotientDecimal = 4000f / 300f / 20f;
        Console.WriteLine($"The quotient of 4000 divided by 300 and divided by 20 is '{quotient}'");
    }
}
```