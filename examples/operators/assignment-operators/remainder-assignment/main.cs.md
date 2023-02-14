```csharp
using System;

class Program
{
    static void Main ()
    {
        // Declare a variable to store a coin count.
        // Assign it the value of 777.
        int coinCount = 777;
        Console.WriteLine($"The coinCount value is '{coinCount}'");
        
        // Modulo coin count by 100
        coinCount %= 100;
        Console.WriteLine($"The coinCount value is '{coinCount}'");
        
        // Modulo coin count by 10
        coinCount %= 10;
        Console.WriteLine($"The coinCount value is '{coinCount}'");
        
        // Modulo coin count by 5
        coinCount %= 5;
        Console.WriteLine($"The coinCount value is '{coinCount}'");
    }
}
```