using System;

class Program
{
    static void Main()
    {
        // We need a really big integer to hold a number this large.
        long phoneNumber = 18003456789;
        
        // When we go to print the number, we assign each number to one of the
        // # symbols. We need the exact amount of numbers to match it, but in
        // practice we could use if-statements to manage that.
        Console.WriteLine($"Phone number: {phoneNumber:+#-(###)-###-####}");
    }
}
