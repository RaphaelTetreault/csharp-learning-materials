using System;

class Program
{
    static void Main()
    {
        // Lets have a quick look at the Logical Negation / NOT operator !
        // This is a unary operator which means it operates on one value only.
        Console.WriteLine("Let's see how the NOT operator works.");
        Console.WriteLine($"!{true} = {!true}");
        Console.WriteLine($"!{false} = {!false}");
        Console.WriteLine();

        // We can use it to invert the state of a boolean. This can be useful
        // to check the opposite of some information we have.
        int age = 18;
        bool isAgeUnder21 = age < 21;
        bool isAgeOver20 = !isAgeUnder21;
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Is age under 21? {isAgeUnder21}");
        Console.WriteLine($"Is age over 20? {isAgeOver20}");
    }
}