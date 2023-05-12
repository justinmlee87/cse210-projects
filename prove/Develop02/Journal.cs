using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>() {
        "What was one positive thing that happend to you today?",
        "What emotion would you say describes your mood today?",
        "Who did you interact with today?",
        "What did you do to serve someone else today?",
        "What scriptures did you read today? ",
    };

   
    public void AddEntry()
    {
        
        Random random = new Random();
        int index = random.Next(prompts.Count);
        string prompt = prompts[index];

        
        Console.Write(prompt + " ");
        string response = Console.ReadLine();

        
        Entry entry = new Entry {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now
        };
        entries.Add(entry);
        Console.WriteLine("Entry saved successfully!");
    }

    
    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.Date.ToString("MM/dd/yyyy") + " - " + entry.Prompt + " - " + entry.Response);
        }
    }

    
    public void SaveJournal()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine(entry.Date.ToString("MM/dd/yyyy") + " - " + entry.Prompt + " - " + entry.Response);
                }
            }
            Console.WriteLine("Journal saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    
    public void LoadJournal()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(new string[] { " - " }, StringSplitOptions.None);
                    Entry entry = new Entry {
                        Prompt = parts[1],
                        Response = parts[2],
                        Date = DateTime.ParseExact(parts[0], "MM/dd/yyyy", null)
                    };
                    entries.Add(entry);
                }
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}