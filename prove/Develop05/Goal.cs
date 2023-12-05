using System;
using System.Collections.Generic;
using System.IO;

public class Goal
{
    private bool MenuRun = true;
    private List<BaseGoal> goals = new List<BaseGoal>();

    public void Run()
    {
        while (MenuRun)
        {
            ShowMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BaseGoal simpleGoal = new BasicGoal();
                    simpleGoal.Name();
                    simpleGoal.SumPoints();
                    simpleGoal.Save();
                    goals.Add(simpleGoal);
                    return;
                case "2":
                    BaseGoal eternalGoal = new EternalGoal();
                    eternalGoal.Name();
                    eternalGoal.SumPoints();
                    eternalGoal.Save();
                    goals.Add(eternalGoal);
                    return;
                case "3":
                    BaseGoal checklistGoal = new Checklist();
                    checklistGoal.Name();
                    checklistGoal.SumPoints();
                    if (checklistGoal is Checklist checklist)
                    {
                        checklist.TimesToAccomplish();
                        checklist.BonusPoints();
                    }
                    goals.Add(checklistGoal);
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }

    static void ListGoals(List<BaseGoal> goals)
    {
        Console.WriteLine("List of Goals:");

        foreach (BaseGoal goal in goals)
        {
            string status = goal.IsCompleted() ? "[X]" : "[ ]";
            string displayText = $"{status} {goal.GetGoalName()} ({goal.GetGoalDescription()})";


            if (goal is BasicGoal basicGoal)
            {
             
            }
            else if (goal is EternalGoal eternalGoal)
            {
               
            }
            else if (goal is Checklist checklistGoal)
            {
                
                displayText += $"{checklistGoal.GetAdditionalInfo()}";
            }

            Console.WriteLine(displayText);
        }
    }

    public void SaveGoalsCustomFormat()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string userFileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(userFileName + ".txt", true))
        {
            foreach (BaseGoal goal in goals)
            {
                writer.WriteLine(goal.SaveGoalInfo());
            }
        }

        Console.WriteLine($"Goals saved in {userFileName}.txt");
    }

    private static void ShowMenu()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. CheckList Goal");
        Console.WriteLine("Which type of goal would you like to create?");
    }
}
