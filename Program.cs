using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a day number (1-7):");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int dayNumber) && dayNumber >= 1 && dayNumber <= 7)
        {
            string dayName = GetDayName(dayNumber);
            Console.WriteLine($"Day of the week: {dayName}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
        }
    }

    static string GetDayName(int dayNumber)
    {
        switch (dayNumber)
        {
            case 1: return "Monday";
            case 2: return "Tuesday";
            case 3: return "Wednesday";
            case 4: return "Thursday";
            case 5: return "Friday";
            case 6: return "Saturday";
            case 7: return "Sunday";
            default: return "Unknown day";
        }
    }
}


