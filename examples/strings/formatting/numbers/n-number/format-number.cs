using System;

class Program
{
    static void Main()
    {
        // It is often convenient to format numbers. In our day-to-day, we
        // format numbers in a specific way to read them more clearly.
        
        // Here, we declare numbers 3 values which we will format.
        float smallNumber = 32.1f;
        float mediumNumber = 1024.64f;
        float largeNumber = int.MaxValue;
        
        // We can specify a number format by use the "n" or "N" specifier.
        Console.WriteLine("Number formatted for local culture.");
        Console.WriteLine($"Small : {smallNumber:n}");
        Console.WriteLine($"Medium: {mediumNumber:N}");
        Console.WriteLine($"Large : {largeNumber:n}");
        Console.WriteLine();
        
        // By default, we get 2 decimal places. We can pass a number to specify
        // the number of decimal places we would like.
        Console.WriteLine($"Small : {smallNumber:n1}");
        Console.WriteLine($"Medium: {mediumNumber:n5}");
        Console.WriteLine($"Large : {largeNumber:n0}");
        Console.WriteLine();
        
        // Note: .NET will format the number using your computers' culture info.
        // For instance, in France, the decimal separator is a comma ',' instead
        // of a period '.' character. Also, gaps between digits is a space ' '
        // rather than a comma ',' character.
        System.Globalization.CultureInfo cultureInfo =
          new System.Globalization.CultureInfo("fr-FR");
        Console.WriteLine("Number formatted for France.");
        Console.WriteLine($"Small : {smallNumber.ToString("n", cultureInfo)}");
        Console.WriteLine($"Medium: {mediumNumber.ToString("n", cultureInfo)}");
        Console.WriteLine($"Large : {largeNumber.ToString("n", cultureInfo)}");
        Console.WriteLine();
    }
}