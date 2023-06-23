using System;
using System.Collections.Generic;

// Base class for goals
public abstract class Goal
{
    public string Name { get; set; }
    public int Value { get; set; }
    public bool Completed { get; set; }

    public Goal(string name, int value)
    {
        Name = name;
        Value = value;
        Completed = false;
    }

    public abstract void Complete();
}
