using System;

namespace VideoComments
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            Video v1 = new Video("How to Play Guitar", "Justin Lee", 600);
            v1.Comments.Add(new Comment("Tanner", "This is extremely helpful!"));
            v1.Comments.Add(new Comment("Tyler", "Can you do a follow up video focusing more on chords?"));
            v1.Comments.Add(new Comment("Steve", "It's going to take a lot of practice!"));
            v1.Comments.Add(new Comment("Cheyanne", "I hope I can play like that some day!"));
            videos.Add(v1);

            Video v2 = new Video("Intro to Chords", "Justin Lee", 700);
            v2.Comments.Add(new Comment("Wendy", "I really like to use the D chord!"));
            v2.Comments.Add(new Comment("David", "Great examples of different chords!"));
            v2.Comments.Add(new Comment("Jeannette", "Thanks for the examples!"));
            videos.Add(v2);

            Video v3 = new Video("Picking Practice", "Justin Lee", 500);
            v3.Comments.Add(new Comment("Sean", "These are great warm up tips."));
            v3.Comments.Add(new Comment("Brian", "Hopefully I will get better!"));
            videos.Add(v3);

            foreach (Video v in videos)
            {
                Console.WriteLine("Title: " + v.Title);
                Console.WriteLine("Author: " + v.Author);
                Console.WriteLine("Length: " + v.Length + " seconds");
                Console.WriteLine("Number of comments: " + v.GetNumComments());
                Console.WriteLine("Comments:");

                foreach (Comment c in v.Comments)
                {
                    Console.WriteLine("- " + c.Name + ": " + c.Text);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}