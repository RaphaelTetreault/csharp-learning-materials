using System;

class Program
{
    static void Main()
    {
        // It is often convenient to format numbers.
        // Sometimes displaying numbers in their binary representation
        // is useful, especially when working closer to the hardware level.
        
        
        // Here, we declare numbers 3 different ways.
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
        Console.WriteLine($"Binary: {ToBinaryString(binaryNumber)}");
        Console.WriteLine($"Decimal: {ToBinaryString(decimalNumber)}");
        Console.WriteLine($"Hexadecimal: {ToBinaryString(hexadecimalNumber)}");
        Console.WriteLine();
    }

    // This function converts a unsigned integer into its string representation.
    static string ToBinaryString(uint value)
    {
        // This converts the integer to a string in base 2 (binary).
        string binaryString = Convert.ToString(value, 2);

        // This pads the left side with 0s so all results are 32 digits wide.
        binaryString = binaryString.PadLeft(32, '0');
        Console.WriteLine(binaryString);

        string formatted = "";
        for (int i = 0; i < 4; i++)
        {
            int index = i * 8;
            string digits8 = binaryString.Substring(index, 8);
            formatted += digits8;

            if (i < 3)
                formatted += "_";
        }

        return formatted;
    }
}