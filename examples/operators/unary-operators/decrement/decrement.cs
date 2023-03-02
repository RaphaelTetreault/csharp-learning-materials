using System;

class Program
{
    static void Main()
    {
        // Lets have a quick look at the negative unary operator --
        // There are actually 2 version, pre-decrement and post-decrement.
        int number = 0;
        Console.WriteLine($"Let's see how the -- operator works.");
        Console.WriteLine($"number: {number}");

        // Here, we decrement the number by 1 using the post-decrement operator.
        number--;
        Console.WriteLine($"number--: {number}");

        // Here, we decrement the number by 1 using the pre-decrement operator.
        --number;
        Console.WriteLine($"--number: {number}");

        // Let's decrement another 3 times;
        number--;
        number--;
        --number;
        Console.WriteLine($"number decremented 3 more times: {number}");

        // So what is the difference? The clue is in the prefix: the variable is
        // decremented either before (pre-) or after (post-) it is evaluated.
        // Let's see two more scenarios where the value is decremented inside
        // a statement which tries to evaluate it "at the same time."
        Console.WriteLine($"Let's evaluate 'number' inside a statement.");
        Console.WriteLine($"number--: {number--}");
        Console.WriteLine($"--number: {--number}");
        Console.WriteLine();
        
        // You'll notice the output will read:
        // "number--: 5"
        // "--number: 7"
        // We see 5 first because the variable 'number' gets evaluated before
        // we decrement it since we used post-decrement. We see 7 after because
        // the value of 'number' was 6 after it was printed, then we decremented
        // it again before printing it a second time, so the value was 7.
        
        // In some sense, the -- acts as a shorthand for the following code:
        Console.WriteLine($"Let's manually decrement 'number'");
        number = number - 1;
        Console.WriteLine($"number = number - 1: {number}");
        number -= 1;
        Console.WriteLine($"number -= 1: {number}");
        Console.WriteLine();

        // The important thing to remember is -- changes the value.
        // This is code we might write.
        Console.WriteLine($"Correct use");
        Console.WriteLine($"Number is currently: {number}");
        int prevNumber = number - 1;
        Console.WriteLine($"number: {number}, previous number: {prevNumber}");
        
        // Don't accidentally do this.
        Console.WriteLine($"Incorrect use");
        Console.WriteLine($"Number is currently: {number}");
        prevNumber = number--;
        Console.WriteLine($"number: {number}, previous number: {prevNumber}");
        
        // And don't do this, too!
        Console.WriteLine($"Incorrect use");
        Console.WriteLine($"Number is currently: {number}");
        prevNumber = --number;
        Console.WriteLine($"number: {number}, previous number: {prevNumber}");
    }
}