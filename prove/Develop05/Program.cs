using System;
using System.Collections.Generic;

// Main program
public class Program
{
    private static List<Goal> goals = new List<Goal>();

    private static void Main()
    {
        LoadGoals(); // Load goals from storage

        bool exitProgram = false;
        while (!exitProgram)
        {
            Console.WriteLine("Eternal Quest - Goal Tracker");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1. View Goals");
            Console.WriteLine("2. Add Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    ViewGoals();
                    break;
                case "2":
                    AddGoal();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    exitProgram = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private static void ViewGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
        }
        else
        {
            Console.WriteLine("Goals:");
            foreach (var goal in goals)
            {
                string completionStatus = goal.Completed ? "[X]" : "[ ]";
                string goalInfo = goal is ChecklistGoal checklistGoal
                    ? $"{completionStatus} {goal.Name} (Completed {checklistGoal.CurrentCount}/{checklistGoal.TargetCount} times)"
                    : $"{completionStatus} {goal.Name}";

                Console.WriteLine(goalInfo);
            }
        }
    }

    private static void AddGoal()
    {
        Console.WriteLine("Goal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter goal type: ");
        string goalTypeChoice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string goalName = Console.ReadLine();

        Console.Write("Enter goal value: ");
        int goalValue = Convert.ToInt32(Console.ReadLine());

        switch (goalTypeChoice)
        {
            case "1":
                goals.Add(new SimpleGoal(goalName, goalValue));
                Console.WriteLine("Simple goal added.");
                break;
            case "2":
                goals.Add(new EternalGoal(goalName, goalValue));
                Console.WriteLine("Eternal goal added.");
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = Convert.ToInt32(Console.ReadLine());
                goals.Add(new ChecklistGoal(goalName, goalValue, targetCount));
                Console.WriteLine("Checklist goal added.");
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal not added.");
                break;
        }
    }

    private static void RecordEvent()
    {
        Console.Write("Enter the index of the goal to record an event: ");
        int goalIndex = Convert.ToInt32(Console.ReadLine());

        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            Goal goal = goals[goalIndex];
            goal.Complete();
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    private static void SaveGoals()
    {
        // Save goals to storage
        Console.WriteLine("Goals saved.");
    }

    private static void LoadGoals()
    {
        // Load goals from storage
        Console.WriteLine("Goals loaded.");
    }
}