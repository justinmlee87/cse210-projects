using System;
using System.Collections.Generic;
using System.Threading;

// The base class for all activities
abstract class Activity
{
    protected int duration;

    public Activity(int duration)
    {
        this.duration = duration;
    }

    public abstract void Start();

    protected void DisplayMessage(string message)
    {
        Console.WriteLine(message);
        Thread.Sleep(2000); // Pause for 2 seconds
    }

    protected void DisplayCountdown(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.WriteLine($"Countdown: {i} seconds");
            Thread.Sleep(1000); // Pause for 1 second
        }
    }

    public void Run()
    {
        Start();
        Console.WriteLine("Good job! You have completed the activity.");
        Thread.Sleep(2000); // Pause for 2 seconds
    }
}