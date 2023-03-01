using System;

class Program
{
    static void Main()
    {
        // Let's write out a value in decimal and in binary.
        const byte value1 = 77;
        const byte value2 = 0b1010_1111;
        
        // Let's see what they look like printed as binary.
        Console.WriteLine($"{nameof(value1)}: {ToBinaryString(value1)}, {value1}.");
        Console.WriteLine($"{nameof(value2)}: {ToBinaryString(value2)}, {value2}.");

        // Let's perform a bitwise OR using the pipe character '|'
        byte result = value1 | value2;
        
        // Let's see the result
        Console.WriteLine($"{nameof(result)}: {ToBinaryString(result)}, {result}.");
    }
    
    // This function converts a byte into its string representation.
    static string ToBinaryString(byte value)
    {
        // This converts the integer to a string in base 2 (binary).
        string binaryString = Convert.ToString(value, 2);
        // This pads the left side with 0s so all results are 8 digits wide.
        binaryString = binaryString.PadLeft(8, '0');
        return binaryString;
    }
}