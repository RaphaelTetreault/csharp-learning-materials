```csharp
using System;

class Program
{
    static void Main()
    {
        // Declare a variable to store health.
        // Assign it the value of 1,000.
        int health = 1000;
        Console.WriteLine($"The health value is '{health}'");
        
        // Divide health by 100
        health /= 10;
        Console.WriteLine($"The health value is '{health}'");
        
        // Divide health by 3
        health /= 3;
        Console.WriteLine($"The health value is '{health}'");
        
        // Divide health by 10
        health /= 7;
        Console.WriteLine($"The health value is '{health}'");
    }
}
```