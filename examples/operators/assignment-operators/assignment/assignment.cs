using System;

class Program
{
    static void Main()
    {
        // To tell C# we want a variable, we need to declare them.
        // We do this by writing the variable type followed by a name.
        // The name can include any letter, number, or an underscore.
        // The only rule is the variable name must not start with a number.
        
        // Here, we declared a few variables with commonly used types. 
        int wholeNumber;
        float decimalNumber;
        string sentence;
        
        // C# does not like it when we try to use variables without assigning
        // a value first, so let us assign a value using the equals sign '='.
        // We will return to unassigned variables when we discuss encapsulation.
        wholeNumber = 100;
        decimalNumber = 12.3f;
        sentence = "This is a C# string!";
        
        // Now, let's print the contents of these variables to the console.
        // I will be using a few things that may look unfamiliar if you are
        // new to C# or programming.
        Console.WriteLine($"{nameof(wholeNumber)}: {wholeNumber}");
        Console.WriteLine($"{nameof(decimalNumber)}: {decimalNumber}");
        Console.WriteLine($"{nameof(sentence)}: \"{sentence}\"");

        // The nameof() used here is a special C# expression. It gets replaced  
        // with a string value which matches the name of the value passed in
        // when our code gets compiled.
        
        // The \" is called an escape sequence. Recall that we define a string
        // inside two quotation marks. However, what if we want to print a
        // quotation mark inside a string? We need a way to tell C# to print
        // the character instead of interpreting it as part of our code. The
        // backslash character '\' begins the escape sequence, telling C#
        // to treat the next character " differently; \" prints ".
    }
}