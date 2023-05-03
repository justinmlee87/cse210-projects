using System;

class Program
{
    static void Main(string[] args)
    {
     job job1 = new job();
     job1._company = "Disney";
     job1._jobTitle = "Software Engineer";
     job1._startYear = 2017;
     job1._endYear = 2023;


     job job2 = new job();
     job2._company = "Apple";
     job2._jobTitle = "Cybersecurity";
     job2._startYear = 2015;
     job2._endYear = 2017;


     Resume myResume = new Resume();
     myResume._name = "Justin Lee";

     myResume._jobs.Add(job1);

     myResume.Display();
    }
}