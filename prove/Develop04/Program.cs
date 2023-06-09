using System;
using System.Collections.Generic;
using System.Threading;


class Program
{
static void Main(string[] args)
{
Console.WriteLine("Welcome to the Mindfulness App!");
    while (true)
    {
        Console.WriteLine("Please choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("Enter the duration in seconds:");
                int breathingDuration = int.Parse(Console.ReadLine());
                BreathingActivity breathingActivity = new BreathingActivity(breathingDuration);
                breathingActivity.Run();
                break;
            case "2":
                Console.WriteLine("Enter the duration in seconds:");
                int reflectionDuration = int.Parse(Console.ReadLine());
                ReflectionActivity reflectionActivity = new ReflectionActivity(reflectionDuration);
                reflectionActivity.Run();
                break;
            case "3":
                Console.WriteLine("Enter the duration in seconds:");
                int listingDuration = int.Parse(Console.ReadLine());
                ListingActivity listingActivity = new ListingActivity(listingDuration);
                listingActivity.Run();
                break;
            case "4":
                Console.WriteLine("Thank you for using the Mindfulness App. Goodbye!");
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}
}