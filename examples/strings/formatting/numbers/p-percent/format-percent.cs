using System;

class Program
{
    static void Main()
    {
        // It is often convenient to format numbers. Often a percentage printout
        // is useful. .NET provides an easy way to do this.
        
        // Here, we declare numbers 5 values to represent a percentage.
        // The range of a percentage is between 0 and 1 inclusive at both ends.
        float zero = 0;
        float half = 0.5f;
        float twoThirds = 2f / 3f;
        float one = 1;
        float two = 2;
        
        // We can specify a percentage format by use the "p" or "P" specifier.
        Console.WriteLine($"Zero......: {zero:p}");
        Console.WriteLine($"Half......: {half:p}");
        Console.WriteLine($"Two thirds: {twoThirds:P}");
        Console.WriteLine($"One.......: {one:P}");
        Console.WriteLine($"Two.......: {two:P}");
        Console.WriteLine();
        
        // By default, we get 2 decimal places. We can pass a number to specify
        // the number of decimal places we would like.
        Console.WriteLine($"Zero......: {zero:p3}");
        Console.WriteLine($"Half......: {half:p1}");
        Console.WriteLine($"Two thirds: {twoThirds:P5}");
        Console.WriteLine($"One.......: {one:P0}");
        Console.WriteLine($"Two.......: {two:P}");
        Console.WriteLine();
        
        // Of course, we can do this directly through the ToString function.
        // The value is suvject to the precision, though.
        string text = twoThirds.ToString("p10");
        Console.WriteLine($"Float : {text}");
        
        // Do the above again but with a double precision floating point number.
        double dTwoThirds = 2.0 / 3.0;
        text = dTwoThirds.ToString("p10");
        Console.WriteLine($"Double: {text}");
    }
}