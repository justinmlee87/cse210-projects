using System;
using System.Collections.Generic;
using System.Threading;


// The Reflection Class
class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you overcame something difficult.",
        "Think of a time when you gave service to someone else.",
        "Think of a time when someone served you.",
        "Think of a time when you took intiative spiritually."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did this experience make you feel?",
        "What stood out to you about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int duration) : base(duration)
    {
    }

    public override void Start()
    {
        DisplayMessage("Reflection Activity");
        DisplayMessage("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("Please enter the duration in seconds: " + duration);
        DisplayMessage("Get ready to begin...");
        Thread.Sleep(2000); // Pause for 2 seconds

        Random random = new Random();
        int promptIndex = random.Next(prompts.Count);
        string prompt = prompts[promptIndex];

        DisplayMessage(prompt);

        foreach (string question in questions)
        {
            DisplayMessage(question);
            DisplayCountdown(10); // Countdown from 3 seconds
        }
    }
}
