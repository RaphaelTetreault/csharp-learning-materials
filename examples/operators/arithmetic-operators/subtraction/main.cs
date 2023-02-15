using System;

class Program
{
    static void Main()
    {
        // We can subtract a numbers from another using the '-' sign
        Console.WriteLine($"The difference of 12 minus 5 is '{12 - 5}'");

        // We can assign the difference of numbers to a variable
        int difference = 99 - 9;
        Console.WriteLine($"The difference of 99 minus 9 is '{difference}'");

        // We can subtract many numbers in sequence.
        difference = 4000 - 300 - 20 - 1;
        Console.WriteLine($"The difference of 4000 minus 300, 20 and 1 is '{difference}'");
    }
}
