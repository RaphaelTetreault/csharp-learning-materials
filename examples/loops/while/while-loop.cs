using System;

class Program
{
    static void Main ()
    {
        int loopCount = 0;
        bool continueLoop = true;
        
        // Repeat the loop until we are told to stop
        while(continueLoop)
        {
            // Increment loop count
            loopCount++;
            
            // Write out how many times we have looped
            Console.WriteLine($"This is loop iteration number {loopCount}!");
            // Ask user if they wish to stop
            Console.WriteLine("Should I stop? Type 'y' for yes and anything else for no.");
            string userInput = Console.ReadLine();
            // Assign the Boolean which controls this loop to 'false' if the user
            // typed "y" otherwise we stay as true
            continueLoop = userInput != "y";
        }
        
        Console.WriteLine($"We looped a total of {loopCount} times!");
    }
}
