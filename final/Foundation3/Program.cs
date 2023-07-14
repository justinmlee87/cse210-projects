using System;

class Program {
    static void Main(string[] args) {
        Address address1 = new Address("87 Aragorn St", "Minas Tirith", "WA", "12345");
        Address address2 = new Address("112 Gandalf Ln", "Hobbiton", "UT", "78912");
        Address address3 = new Address("787 Saruman Dr", "Isengard", "NY", "87654");

        Event genericEvent = new Event("Generic Event", "A generic event", new DateTime(2023, 4, 1), new TimeSpan(19, 0, 0), address1);
        Lecture lecture = new Lecture("Lecture on Charity", "A lecture on what is true Charity.", new DateTime(2023, 5, 1), new TimeSpan(13, 0, 0), address2, "Dr. Frodo Baggins", 50);
        Reception reception = new Reception("Wedding Reception", "The Wedding Reception for Aragorn and Arwen", new DateTime(2023, 6, 1), new TimeSpan(18, 0, 0), address3, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("King Theoden's Speech", "Riders of Rohan Speech to motivate the soldiers.", new DateTime(2023, 7, 1), new TimeSpan(11, 0, 0), address1, "Sunny");

        Console.WriteLine(genericEvent.GetStandardDetails());
        Console.WriteLine(genericEvent.GetFullDetails());
        Console.WriteLine(genericEvent.GetShortDescription());

        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}