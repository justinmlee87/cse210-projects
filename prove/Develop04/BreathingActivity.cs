using System;
using System.Collections.Generic;
using System.Threading;


// The Breathing Activity Class

class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration)
    {
    }

    public override void Start()
    {
        DisplayMessage("Breathing Activity");
        DisplayMessage("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("Please enter the duration in seconds: " + duration);
        DisplayMessage("Get ready to begin...");
        Thread.Sleep(2000); // Pause for 2 seconds

        for (int i = 0; i < duration; i++)
        {
            if (i % 2 == 0)
                DisplayMessage("Breathe in...");
            else
                DisplayMessage("Breathe out...");

            DisplayCountdown(3); // Countdown from 3 seconds
        }
    }
}