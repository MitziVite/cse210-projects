using System;
using System.Collections.Specialized;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter = "";        

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        } 
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60) 
        { 
            letter = "D";
        }
        else if (number < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"You're grade is {letter}");

        if (number > 70)
        {
            Console.WriteLine("Congrats you passed the class");
        }
        else if (number < 70 )
        {
            Console.WriteLine("You didn't pass. But, it is ok, you will get it next time.");
        }
    }
}