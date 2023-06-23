using System;
using System.Collections.Generic;

// Checklist goal
public class ChecklistGoal : Goal
{
    public int TargetCount { get; }
    public int CurrentCount { get; private set; }

    public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
    }

    public override void Complete()
    {
        CurrentCount++;
        Console.WriteLine($"You recorded progress for checklist goal '{Name}'. You earned {Value} points.");

        if (CurrentCount >= TargetCount)
        {
            Completed = true;
            Console.WriteLine($"Congratulations! Goal '{Name}' completed {TargetCount} times. You earned a bonus of {Value} points.");
        }
    }
}