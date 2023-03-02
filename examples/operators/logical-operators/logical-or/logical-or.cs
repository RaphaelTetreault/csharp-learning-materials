using System;

class Program
{
    static void Main()
    {
        // Lets have a quick look at the Logical OR operator ||
        Console.WriteLine("Let's see how the OR operator works.");
        Console.WriteLine($"{true} || {true} = {true || true}");
        Console.WriteLine($"{true} || {false} = {true || false}");
        Console.WriteLine($"{false} || {true} = {false || true}");
        Console.WriteLine($"{false} || {false} = {false || false}");
        // Because the || operator evaluates 2 booleans and returns 1
        // boolean, we can compare multiple in a row. This collapses
        // multiple comparisions down into 1 final bool.
        Console.WriteLine($"{true} || {true} || {false} = {true || true || false}");
        Console.WriteLine($"{false} || {true} || {false} = {false || true || false}");
        Console.WriteLine();
        
        // Lets now try this with some variables!
        // Assume this defines some preferences of a person.
        bool doesLikeSweet = true;
        bool doesLikeSalty = true;
        bool doesLikeSpicy = false;
        bool doesLikeSour = false;
        Console.WriteLine($"Person likes sweet foods? {doesLikeSweet}");
        Console.WriteLine($"Person likes salty foods? {doesLikeSalty}");
        Console.WriteLine($"Person likes spicy foods? {doesLikeSpicy}");
        Console.WriteLine($"Person likes sour foods? {doesLikeSour}");

        // Now we can compare these properties to learn a bit more.
        bool mightLikeSaltedChocolate = doesLikeSweet || doesLikeSalty;
        Console.WriteLine($"Might like salted chocolate? {mightLikeSaltedChocolate}");
        
        bool mightLikeMexicanHotChocolate = doesLikeSweet || doesLikeSpicy;
        Console.WriteLine($"Might like Mexican hot chocolate? {mightLikeMexicanHotChocolate}");
        
        bool mightLikeKimchi = doesLikeSweet || doesLikeSpicy || doesLikeSour;
        Console.WriteLine($"Might like kimchi? {mightLikeKimchi}");
    }
}