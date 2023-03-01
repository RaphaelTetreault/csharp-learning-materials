```csharp
using System;

class Program
{
    static void Main()
    {
        // Let's write out a value in binary.
        byte value = 0b1010_0110;
        
        // Let's see what it look like printed as a decimal.
        Console.WriteLine($"{nameof(value)}: {ToBinaryString(value)}, {value}");
        Console.WriteLine();

        // Let's perform a shift-right 9 times to see how the operator works.
        for (int i = 0; i <= 8; i++)
        {
            // Let's perform a shift-right using two greater-than signs ">>".
            byte result = (byte)(value >> i);
            
            // Let's see the result
            string valueStr = ToBinaryString(value);
            string resultStr = ToBinaryString(result);
            Console.WriteLine($"{valueStr} >> {i} = {resultStr}, {result}");
        }
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
}```