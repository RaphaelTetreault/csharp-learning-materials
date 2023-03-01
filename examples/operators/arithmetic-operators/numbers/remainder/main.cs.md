```csharp
using System;

class Program
{
    static void Main()
    {
        // This section uses integer math (whole numbers only)
        Console.WriteLine("Integer Math");

        // We can get the remainder of a division by using the '%' sign
        Console.WriteLine($"The remainder of 12 divided by 5 is '{12 % 5}'");

        // We can assign the remainder to a variable
        int remainder = 99 % 9;
        Console.WriteLine($"The remainder of 99 divided by 9 is '{remainder}'");

        // We can divide many numbers in sequence
        remainder = 4000 % 300 % 15;
        Console.WriteLine($"The remainder of 4000 divided by 300 and divided by 20 is '{remainder}'");


        // This section uses floating point math (numbers with decimal points)
        Console.WriteLine();
        Console.WriteLine("Floating Point Math");

        // We can of course get decimal point reaminders, too
        Console.WriteLine($"The remainder of 12.125 divided by 5.366 is '{12.125f % 5.366f}'");
    }
}
```