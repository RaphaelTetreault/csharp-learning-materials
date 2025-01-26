using System;

class Program
{
    static void Main()
    {
        // It is often convenient to format numbers.
        // Sometimes displaying numbers in their hexadecimal representation
        // is useful, especially when working closer to the hardware level.
        
        // Here, we declare numbers 3 different ways. HexSpeak used for fun.
        uint binaryNumber = 0b1111000111111010; // FIFA
        uint decimalNumber = 3735928559;        // DEAD BEEF
        uint hexadecimalNumber = 0xCAFEB0BA;    // CAFE BOBA
        
        // When we print the numbers, we will by default see it as decimal.
        // This is regardless of how we declared the numbers.
        Console.WriteLine($"Binary: {binaryNumber}");
        Console.WriteLine($"Decimal: {decimalNumber}");
        Console.WriteLine($"Hexadecimal: {hexadecimalNumber}");
        Console.WriteLine();

        // To print as Hexadecimal, we use the 'x' modifier.
        Console.WriteLine($"Binary: {binaryNumber:x}");
        Console.WriteLine($"Decimal: {decimalNumber:x}");
        Console.WriteLine($"Hexadecimal: {hexadecimalNumber:x}");
        Console.WriteLine();
        
        // To use capital letters, we use the capital 'X' modifier.
        Console.WriteLine($"Binary: {binaryNumber:X}");
        Console.WriteLine($"Decimal: {decimalNumber:X}");
        Console.WriteLine($"Hexadecimal: {hexadecimalNumber:X}");
        Console.WriteLine();

        // And lastly, to force a minimum amount of characters, we
        // can specify how many characters we want.
        Console.WriteLine($"Binary: {binaryNumber:X8}");
        Console.WriteLine($"Decimal: {decimalNumber:X4}");
        Console.WriteLine($"Hexadecimal: {hexadecimalNumber:X1}");
        Console.WriteLine();
        
        // Of course, we can do this directly through the ToString function.
        string text = binaryNumber.ToString("X8");
        Console.WriteLine(text);
    }
}