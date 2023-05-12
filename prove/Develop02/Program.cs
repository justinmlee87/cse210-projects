using System;
using System.Collections.Generic;
using System.IO;


public class Program
{
    private static Journal journal = new Journal();

    static void Main(string[] args)
    {
        while (true)
        {
            
            Console.WriteLine();
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            
            string choice = Console.ReadLine();

            
            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.SaveJournal();
                    break;
                case "4":
                    journal.LoadJournal();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please enter a number from 1 to 5.");
                    break;
            }
        }
    }
}