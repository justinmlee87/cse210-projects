using System;
using System.Collections.Generic;

// Eternal goal
public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value)
    {
    }

    public override void Complete()
    {
        Console.WriteLine($"You recorded progress for eternal goal '{Name}'. You earned {Value} points.");
    }
}
