# Emoji in Windows Terminal

## Requirements

The default terminals `cmd.exe` and `powershell.exe` do not print emoji in Windows. `wt.exe` (Windows Terminal) does, though the input of an emoji is currently broken (ie: input character is garbled, but the output print of the character is correct). By default, the Visual Studio console programs use some version of the former app when debugging/running. 

The hack "workaround" is to run the application in `wt.exe`. I have not found a way to run it directly, but by using the Visual Studio > Tools > External Tools option, you can set up a command which launches `wt.exe` and passes the argument to open the last build of the program (in `bin/debug/etc`).

## Sample Code

```csharp
// Set the output encoding to Unicode (default is UTF8?)
Console.OutputEncoding = System.Text.Encoding.Unicode;
// Print the emoji in a string
Console.WriteLine("😀");
```

## Other Info

Based on this answer, it is stated that the Console Application "terminal" seen when running a program in Visual Studio is in fact the program itself - the window is not just another program used to view the output stream. https://learn.microsoft.com/en-us/answers/questions/845363/change-from-vs-debug-console-to-powershell-for-run.

Here is a list of the Unicode emoji. [https://unicode.org/emoji/charts/full-emoji-list.html](https://unicode.org/emoji/charts/full-emoji-list.html).