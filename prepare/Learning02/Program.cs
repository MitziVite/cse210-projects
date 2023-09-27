using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company="Microsoft";
        job1._jobTitle="CS";


        Job job2 = new Job();
        job2._company="Disney";
        job2._jobTitle="SE";
  

        Resume myResume = new Resume();
        myResume._name = "Daniel";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.display();

    }
}
