using System;

class Program
{
    static void Main()
    {
        // Let's write out a value in binary.
        byte value = 0b0110_1010;
        
        // Let's see what it look like printed as a decimal.
        Console.WriteLine($"{nameof(value)} : {ToBinaryString(value)}, {value}.");

        // Let's perform a bitwise NOT using the tilda character '~'.
        // The operator returns an int, so we must cast the value back to a byte.
        byte result = (byte)~value;
        
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