using System;

class Program
{
    static void Main()
    {
        // Precedence:
        // The condition of being considered more important than something else;
        // priority in importance, order, or rank.
        
        // Operator Precendence:
        // The order that an operator is executed relative to other operators.
        
        // You likely learned BEDMAS (or PEDMAS) in a grade school math class.
        // It stands for Brackets/Parentheses, Exponents, Division,
        // Multiplication, Addition, Subtraction. This is the order to solve
        // the arithmetic operators in a math equation.
        
        // Example
        //  2 + 3  * 10 is the same as 2 + 30 which is 32.
        // (2 + 3) * 10 is the same as 5 * 10 which is 50.
        
        // In code, these rules are respected
        int result1 = 2 + 3 * 10;
        int result2 = (2 + 3) * 10;
        Console.WriteLine($" 2 + 3  * 10 = {result1}");
        Console.WriteLine($"(2 + 3) * 10 = {result2}");
        
        // This shines light on operators. Every operator in an expression has
        // a defined "order of execution." You can review them all here.
        // In an IDE, you can likely do CTRL+Click the link below to follow it:
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/#operator-precedence

        // What is likely most import to a beginner are the following
        // The list is from highest precendence to lowest (first to last)
        // #1 Arithmetic
        //      Multiplicative: *, /, %, (multiply, divide)
        //      Additive: +, -, (add, subtract)
        // #2 Relational
    }
}