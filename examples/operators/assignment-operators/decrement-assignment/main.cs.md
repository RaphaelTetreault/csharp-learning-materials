```csharp
using System;

class Program
{
    static void Main ()
    {
        // Declare a variable to store health.
        // Assign it the value of 100.
        float health = 100;
        Console.WriteLine($"The health value is '{health}'");
        
        // Subtract 10 health points from health
        health -= 10;
        Console.WriteLine($"The health value is '{health}'");
        
        // Subtract 33.3 health points from health
        health -= 33.3f;
        Console.WriteLine($"The health value is '{health}'");
        
        // Subtract 999 health points from health
        health -= 999;
        Console.WriteLine($"The health value is '{health}'");
    }
}
```