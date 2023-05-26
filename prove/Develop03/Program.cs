using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = InitializeScriptures();
        Random random = new Random();

        while (scriptures.Count > 0)
        {
            int index = random.Next(scriptures.Count);
            Scripture scripture = scriptures[index];
            HideWords(scripture);

            while (!scripture.AllWordsHidden)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetHiddenText());
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    return;

                HideWords(scripture);
            }

            scriptures.RemoveAt(index);
        }
    }

    static List<Scripture> InitializeScriptures()
    {
        List<Scripture> scriptures = new List<Scripture>();
        scriptures.Add(new Scripture("Hebrews 11:1", "Now faith is the substance of things hoped for, the evidence of things not seen."));
        scriptures.Add(new Scripture("Moroni 10: 4-5", "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things."));
        scriptures.Add(new Scripture("Jacob 2:18-19", "But before ye seek for riches, seek ye for the kingdom of God. And after ye have obtained a hope in Christ ye shall obtain riches, if ye seek them; and if ye seek them for the intent to do good to clothe the naked, and to feed the hungry, and to liberate the captive, and administer relief to the sick and the afflicted."));
        scriptures.Add(new Scripture("James 1:5-6", "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. Forhe that wavereth is like a wave of the sea driven with the wind and tossed."));
        scriptures.Add(new Scripture("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
        scriptures.Add(new Scripture("2 Nephi 31:20", "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life."));

        return scriptures;
    }

    static void HideWords(Scripture scripture)
    {
        List<Word> wordsToHide = new List<Word>();

        foreach (Word word in scripture.Words)
        {
            if (!word.IsHidden)
                wordsToHide.Add(word);
        }

        if (wordsToHide.Count == 0)
            return;

        Random random = new Random();
        int index = random.Next(wordsToHide.Count);
        wordsToHide[index].Hide();
    }
}