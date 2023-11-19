using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Threading;

public class Activity
{
    protected string _description;
    protected string _startingMessage = "Get ready...";
    protected string _finishingMessage = "Well done!! ";

    protected string _beginingMessage = "Begin In:";

    List<string> animationStrings = new List<string>();

    public Activity()
    {
        // Initialize the animationStrings with your specific set of strings
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
    }
    public void GetReady(){
        Console.WriteLine(_startingMessage);
        for(int i = 5; i>0;i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public virtual void Animation(int durationInSeconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(durationInSeconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i % animationStrings.Count]; // Use modulus to wrap around the index
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;
        }
    }

    protected int GetDurationFromUser()
    {
        Console.Write("Please enter the duration in seconds: ");
        int duration;

        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            Console.Write("Please enter the duration in seconds: ");
        }

        return duration;
    }

    public void FinishingMessage(){
        Console.WriteLine(_finishingMessage);
        for(int i = 5; i>0;i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            // Thread.Sleep(1500);
        }
    }

    public void BeginIn(){
        Console.WriteLine(_beginingMessage);
        for(int i = 5; i>0;i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            // Thread.Sleep(1500);
        }
    }
}
