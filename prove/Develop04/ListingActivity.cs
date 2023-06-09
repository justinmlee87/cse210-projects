using System;
using System.Collections.Generic;
using System.Threading;


// The Listing Class
class
ListingActivity : Activity
{
private List<string> prompts = new List<string>
{
"Who are people that you appreciate?",
"What are personal strengths of yours?",
"Who are people that you have helped this week?",
"When have you felt the Holy Ghost this month?",
"Who are some of your personal heroes?"
};public ListingActivity(int duration) : base(duration)
{
}

public override void Start()
{
    DisplayMessage("Listing Activity");
    DisplayMessage("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    Console.WriteLine("Please enter the duration in seconds: " + duration);
    DisplayMessage("Get ready to begin...");
    Thread.Sleep(2000); // Pause for 2 seconds

    Random random = new Random();
    int promptIndex = random.Next(prompts.Count);
    string prompt = prompts[promptIndex];

    DisplayMessage(prompt);

    Console.WriteLine("Start listing...");

    DateTime endTime = DateTime.Now.AddSeconds(duration);
    int itemCount = 0;

    while (DateTime.Now < endTime)
    {
        string item = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(item))
            itemCount++;
    }

    Console.WriteLine($"Number of items listed: {itemCount}");
}
}