using System;
					
public class Program
{
	public static void Main()
	{
		int year = 2000;
		int remainingYears = 100;
		while (remainingYears > 0){
			bool isDivisibleBy4 = year % 4 == 0;
			bool isDivisibleBy100 = year % 100 == 0;
			bool isDivisibleBy400 = year % 400 == 0;
			
			//Console.WriteLine("The year is:         {0}", year);
			//Console.WriteLine("Is divisible by 4?   {0}", isDivisibleBy4);
			//Console.WriteLine("Is divisible by 100? {0}", isDivisibleBy100);
			//Console.WriteLine("Is divisible by 400? {0}", isDivisibleBy400);
			
			bool isLeapYear = isDivisibleBy4 && !isDivisibleBy100 || isDivisibleBy400;
			
			//bool isLeapYear = false;
			//if (isDivisibleBy4)
			//	isLeapYear = true;
			//if (isDivisibleBy100)
			//	isLeapYear = false;
			//if (isDivisibleBy400)
			//	isLeapYear = true;
			
			//bool isLeapYear;
			//if (!isDivisibleBy4)
			//	isLeapYear = false;
			//else if (!isDivisibleBy100)
			//	isLeapYear = true;
			//else if (!isDivisibleBy400)
			//	isLeapYear = false;
			//else 
			//	isLeapYear = true;
				
			if (isLeapYear){
				Console.WriteLine(year);
				remainingYears--;
			}
			
			year++;
		}
	}
}