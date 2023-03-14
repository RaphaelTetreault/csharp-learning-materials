/* THIS PROGRAM REQUIRES C# 11 */

using System;

class Program
{
    static void Main()
    {
        // Let's use a negative number.
        int value = int.MinValue;
        
        // Let's see what it look like printed in binary.
        Console.WriteLine($"{nameof(value)}: {ToBinaryString(value)}, {value}");
        Console.WriteLine();

        // Let's perform an ARITHMETIC shift right 4 times.
        Console.WriteLine("Arithmetic Shift Right");
        for (int i = 0; i < 4; i++)
        {
            int result = (int)(value >> i);
            string valueStr = ToBinaryString(value);
            string resultStr = ToBinaryString(result);
            Console.WriteLine($"{valueStr} >> {i} = {resultStr}, {result}");
        }
        Console.WriteLine();

        // Now let's perform a LOGICAL shift right 4 times.
        Console.WriteLine("Logical Shift Right");
        for (int i = 0; i < 4; i++)
        {
            int result = (int)(value >>> i);
            string valueStr = ToBinaryString(value);
            string resultStr = ToBinaryString(result);
            Console.WriteLine($"{valueStr} >>> {i} = {resultStr}, {result}");
        }
    }
    
    // This function converts a signed integer into its string representation.
    static string ToBinaryString(int value)
    {
        // This converts the integer to a string in base 2 (binary).
        string binaryString = Convert.ToString(value, 2);
        // This pads the left side with 0s so all results are 32 digits wide.
        binaryString = binaryString.PadLeft(32, '0');

        return binaryString;
    }
}