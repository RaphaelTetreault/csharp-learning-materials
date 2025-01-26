using System;

class Program
{
    static void Main()
    {
        // It is often convenient to format numbers. In our day-to-day lives, we
        // display amounts in dollars (or other currencies).
        
        // Here, we declare numbers which represent money. Due to imprecision with
        // floating point numbers, it is recommended you store fractional money
        // as integers in (for example) cents. In such cases, when you need to
        // display it, you can divide the number by 100.
        const double centsInDollar = 100;
        int lunchMoney = 3210;
        int savings = 3027_95; // You can use the undescore chatracter for clarity.
        double displayLunchMoney = lunchMoney / centsInDollar;
        double displaySavings = savings / centsInDollar;

        // We can specify a curency format by use the "c" or "C" specifier.
        Console.WriteLine("Currency formatted for local culture.");
        Console.WriteLine($"Lunch money: {displayLunchMoney:c}");
        Console.WriteLine($"Savings....: {displaySavings:C}");
        Console.WriteLine();
        
        // By default, we get 2 decimal places. We can pass a number to specify
        // the number of decimal places we would like. This is useful if you
        // wish to only show dollar amounts.
        Console.WriteLine("Currency formatted for local culture, no decimal places.");
        Console.WriteLine($"Lunch money: {displayLunchMoney:c0}");
        Console.WriteLine($"Savings....: {displaySavings:C0}");
        Console.WriteLine();
        
        // Note: .NET will format the number using your computers' culture info.
        // For instance in Germany, the decimal separator is a comma ',' instead
        // of a period '.' character. Gaps between digits is a period '.'
        // rather than a comma ',' character. Also, Germany uses the Euro.
        System.Globalization.CultureInfo cultureInfo;
        cultureInfo = new System.Globalization.CultureInfo("de-DE");
        Console.WriteLine("Currency formatted for Germany.");
        Console.WriteLine($"Lunch money: {displayLunchMoney.ToString("c", cultureInfo)}");
        Console.WriteLine($"Savings....: {displaySavings.ToString("c", cultureInfo)}");
        Console.WriteLine();
        
        // Note: not all currencies use cents. The Japanese yen is equivilent to
        // one cent and does not use fractions for some larger denomination.
        // In this case, we would need to print the number directly.
        cultureInfo = new System.Globalization.CultureInfo("ja-JP");
        Console.WriteLine("Currency formatted for Japan.");
        Console.WriteLine($"Lunch money: {lunchMoney.ToString("c", cultureInfo)}");
        Console.WriteLine($"Savings....: {savings.ToString("c", cultureInfo)}");
        Console.WriteLine();
    }
}