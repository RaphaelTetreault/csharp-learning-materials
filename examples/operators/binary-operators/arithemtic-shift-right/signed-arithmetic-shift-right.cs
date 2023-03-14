using System;

class Program
{
    static void Main()
    {
        // Let's write out a value in binary.
        sbyte value = unchecked((sbyte)0b1000_0000);
        
        // Let's see what it look like printed as a decimal.
        Console.WriteLine($"{nameof(value)}: {ToBinaryString(value)}, {value}");
        Console.WriteLine();

        // Let's perform a shift-right 8 times to see how the operator works.
        for (int i = 0; i < 8; i++)
        {
            // Let's perform a shift-right using two greater-than signs ">>".
            sbyte result = (sbyte)(value >> i);
            
            // Let's see the result
            string valueStr = ToBinaryString(value);
            string resultStr = ToBinaryString(result);
            Console.WriteLine($"{valueStr} >> {i} = {resultStr}, {result}");
        }
    }
    
    // This function converts a signed byte into its string representation.
    static string ToBinaryString(sbyte value)
    {
        // This converts the integer to a string in base 2 (binary).
        // Apparently C# converts an sbyte into a short, so it's up to 16 bits.
        string binaryString = Convert.ToString(value, 2);
        // This pads the left side with 0s so all results are 16 digits wide.
        binaryString = binaryString.PadLeft(16, '0');
        // Trim down to 8 bits - the amount of bits an sbyte has
        binaryString = binaryString.Substring(8);
        
        return binaryString;
    }
}