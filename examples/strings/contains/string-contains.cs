using System;

class Program
{
    static void Main()
    {
        // Here's some text we can use to compare.
        string text1 = "Hello, World!";
        string text2 = "The quick brown fox jumps over the lazy dog.";
        string text3 = "I cannot do that.";

        // We can check if a string contains a particular string subset.
        string hello = "Hello";
        bool doesSayHello =  text1.Contains(hello);
        Console.WriteLine($"The text \'{text1}\' contains \"{hello}\"? {doesSayHello}");
        // And we can try again on a different string
        doesSayHello =  text2.Contains(hello);
        Console.WriteLine($"The text \'{text2}\' contains \"{hello}\"? {doesSayHello}");

        // Note that you may catch false-positives if you do not consider the sentence structure.
        string value = "can"; 
        bool canDoThat = text3.Contains(value);
        Console.WriteLine($"Q: Can you do that?\nA: {canYouDoThat}, {text3}");

        // For complex string parsing, you would need to learn about Regular Expressions.
        // Regular Expressions are out of the scope for this course, but know it is a
        // large topic made specifically to pick out strings from within strings.
    }
}