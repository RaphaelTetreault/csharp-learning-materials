using System;

class Program
{
    static void Main()
    {
        // Lets have a quick look at the Logical XOR operator ^
        // XOR stands for eXclusive OR which means one or the other, but not both.
        Console.WriteLine("Let's see how the XOR operator works.");
        Console.WriteLine($"{true} ^ {true} = {true ^ true}");
        Console.WriteLine($"{true} ^ {false} = {true ^ false}");
        Console.WriteLine($"{false} ^ {true} = {false ^ true}");
        Console.WriteLine($"{false} ^ {false} = {false ^ false}");
        // Because the ^ operator evaluates 2 booleans and returns 1
        // boolean, we can compare multiple in a row. This collapses
        // multiple comparisions down into 1 final bool.
        // Note: it works left to right, effectively doing ((a ^ b) ^ c).
        Console.WriteLine($"{true} ^ {true} ^ {false} = {true ^ true ^ false}");
        Console.WriteLine($"{false} ^ {true} ^ {false} = {false ^ true ^ false}");
        Console.WriteLine();
        
        // Lets now try this with some variables!
        // Imagine a game show where two isolated players must guess if they 
        // need to press a buzzer or not. The goal is for one player, but only
        // one player, to press a buzzer. If neither or both players press it,
        // they both lose.

        // ROUND 1
        bool player1PressedBuzzer = false;
        bool player2PressedBuzzer = false;
        bool playersWin = player1PressedBuzzer ^ player2PressedBuzzer;
        Console.WriteLine("ROUND 1");
        Console.WriteLine($"Player 1 pressed: {player1PressedBuzzer}");
        Console.WriteLine($"Player 2 pressed: {player2PressedBuzzer}");
        Console.WriteLine($"Did the contestants win? {playersWin}");

        // ROUND 2
        player1PressedBuzzer = true;
        player2PressedBuzzer = true;
        playersWin = player1PressedBuzzer ^ player2PressedBuzzer;
        Console.WriteLine("ROUND 2");
        Console.WriteLine($"Player 1 pressed: {player1PressedBuzzer}");
        Console.WriteLine($"Player 2 pressed: {player2PressedBuzzer}");
        Console.WriteLine($"Did the contestants win? {playersWin}");

        // ROUND 3
        player1PressedBuzzer = false;
        player2PressedBuzzer = true;
        playersWin = player1PressedBuzzer ^ player2PressedBuzzer;
        Console.WriteLine("ROUND 3");
        Console.WriteLine($"Player 1 pressed: {player1PressedBuzzer}");
        Console.WriteLine($"Player 2 pressed: {player2PressedBuzzer}");
        Console.WriteLine($"Did the contestants win? {playersWin}");
    }
}