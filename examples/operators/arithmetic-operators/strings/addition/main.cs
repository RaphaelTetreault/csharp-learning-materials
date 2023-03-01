using System;

class Program
{
    static void Main()
    {
        // We can add numbers together using the '+' sign
        Console.WriteLine($"Hello, " + "World!");
        Console.WriteLine();

        // We can assign the concatenated value to a variable
        string text = "ABC" + "123";
        Console.WriteLine(text);
        Console.WriteLine();

        // We can also concatenate many strings together at once.
        text = "The quick brown fox" + " jumps over " + "the lazy dog.";
        Console.WriteLine(text);
        Console.WriteLine();

        // Sometimes this is really useful when strings are long.
        // We split them across multiple lines.
        text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed " +
        "do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut  " +
        "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi " +
        "ut aliquip ex ea commodo consequat. Duis aute irure dolor in " +
        "reprehenderit  in voluptate velit esse cillum dolore eu fugiat nulla " +
        "pariatur. Excepteur sint occaecat cupidatat non proident, sunt in " +
        "culpa qui officia deserunt mollit anim id est laborum.";
        Console.WriteLine(text);
        Console.WriteLine();
        
        // Of course, string inpertolation can also be used. C# concatenates
        // strings for us under the hood in a similar way.
        string username = "RaphaelT";
        text = $"Welcome back, {username}!";
        // The above line is functionally the same as the below line:
        //text = "Welcome back, " + username + "!";
        Console.WriteLine(text);
        
    }
}