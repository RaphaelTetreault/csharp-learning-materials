using System;

class Program
{
    static void Main()
    {
        // Lets have a quick look at the Logical AND operator &&
        Console.WriteLine("Let's see how the AND operator works.");
        Console.WriteLine($"{true} && {true} = {true && true}");
        Console.WriteLine($"{true} && {false} = {true && false}");
        Console.WriteLine($"{false} && {true} = {false && true}");
        Console.WriteLine($"{false} && {false} = {false && false}");
        // Because the && operator evaluates 2 booleans and returns 1
        // boolean, we can compare multiple in a row. This collapses
        // multiple comparisions down into 1 final bool.
        Console.WriteLine($"{true} && {true} && {true} = {true && true && true}");
        Console.WriteLine($"{true} && {true} && {false} = {true && true && false}");
        Console.WriteLine();
        
        // Lets now try this with some variables!
        // Assume this defines some properties of a student.
        bool isAgeUnder20 = true;
        bool isStudent = true;
        bool isNinja = false;
        
        // Now we can compare these properties to learn a bit more.
        bool isYoungStudent = isAgeUnder20 && isStudent;
        Console.WriteLine($"Is young student? {isYoungStudent}");
        
        bool isNinjaStudent = isStudent && isNinja;
        Console.WriteLine($"Is a student ninja? {isNinjaStudent}");
        
        bool isYoungNinjaStudent = isAgeUnder20 && isStudent && isNinja;
        Console.WriteLine($"Is young student ninja? {isYoungNinjaStudent}");
    }
}