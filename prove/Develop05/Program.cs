using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public partial class Program
{
    static void Main(string[] args)
    {
        bool continueRunning = true;
        List<BaseGoal> goals = new List<BaseGoal>();
        string userFileName = null; 

        while (continueRunning)
        {
            DisplayMenu();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BaseGoal newGoal = CreateGoal();
                    goals.Add(newGoal);
                    break;
                case "2":
                    ListGoals(goals);
                    break;
                case "3":
                    SaveGoalsCustomFormat(goals, userFileName); 
                    break;
                case "4":
                    Console.WriteLine("Loading goals...");
                    Console.WriteLine(LoadGoalsCustomFormat());
                    break;
                case "5":
                    RecordEvent(goals);
                    break;
                case "6":
                    continueRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create new Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.WriteLine("\nSelect a choice from the menu: ");
    }

    static BaseGoal CreateGoal()
    {
        Console.WriteLine("Select the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string goalType = Console.ReadLine();

        switch (goalType)
        {
            case "1":
                return CreateSimpleGoal();
            case "2":
                return CreateEternalGoal();
            case "3":
                return CreateChecklistGoal();
            default:
                Console.WriteLine("Invalid goal type. Creating Simple Goal by default.");
                return CreateSimpleGoal();
        }
    }

    static BaseGoal CreateSimpleGoal()
    {
        BaseGoal simpleGoal = new BasicGoal();
        simpleGoal.Name();
        simpleGoal.SumPoints();
        return simpleGoal;
    }

    static BaseGoal CreateEternalGoal()
    {
        BaseGoal eternalGoal = new EternalGoal();
        eternalGoal.Name();
        eternalGoal.SumPoints();
        return eternalGoal;
    }

    static BaseGoal CreateChecklistGoal()
    {
        BaseGoal checklistGoal = new Checklist();
        checklistGoal.Name();
        checklistGoal.SumPoints();

        if (checklistGoal is Checklist checklist)
        {
            checklist.TimesToAccomplish();
            checklist.BonusPoints();
        }

        return checklistGoal;
    }

    static void ListGoals(List<BaseGoal> goals)
    {
        Console.WriteLine("List of Goals:");

        foreach (BaseGoal goal in goals)
        {
            string status = goal.IsCompleted() ? "[X]" : "[ ]";
            // string displayText = $"{status} {goal.GetGoalName()} ({goal.GetGoalDescription()}) -- Currently completed {goal.GetTimesCompleted()}/{goal.GetTimesToAccomplish()}";
         
            Console.WriteLine(goal.GetAdditionalInfo());
        }
    }

    static void SaveGoalsCustomFormat(List<BaseGoal> goals, string fileName)
    {

        fileName ??= GetFileNameFromUser();

        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            foreach (BaseGoal goal in goals)
            {
                string saveText = goal.SaveGoalInfo();
                writer.WriteLine(saveText);
            }
        }

        Console.WriteLine($"Goals saved in {fileName}");
    }

    static string GetFileNameFromUser()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string userFileName = Console.ReadLine();

        return Path.ChangeExtension(userFileName, ".txt");
    }

    static void RecordEvent(List<BaseGoal> goals)
    {
        Console.WriteLine("Select the goal you want to record an event for:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetGoalName()}");
        }

        int selectedIndex;
        while (!int.TryParse(Console.ReadLine(), out selectedIndex) || selectedIndex < 1 || selectedIndex > goals.Count)
        {
            Console.WriteLine("Invalid input. Please enter a valid goal number.");
        }

        BaseGoal selectedGoal = goals[selectedIndex - 1];


        if (selectedGoal is BasicGoal basicGoal)
        {
            basicGoal.RecordEvent();
        }
        else if (selectedGoal is EternalGoal eternalGoal)
        {
            eternalGoal.RecordEvent();
        }
        else if (selectedGoal is Checklist checklistGoal)
        {
            checklistGoal.RecordEvent();
        }
        else
        {
            Console.WriteLine("Error: Unsupported goal type.");
        }

        Console.WriteLine($"Event recorded for goal: {selectedGoal.GetGoalName()}");
    }

    static string LoadGoalsCustomFormat()
    {
       
        Console.WriteLine("What is the filename for the goal file?");
        string fileName = Console.ReadLine();

        if (!fileName.EndsWith(".txt"))
        {
            fileName += ".txt";
        }

        if (File.Exists(fileName))
        {
            StringBuilder result = new StringBuilder();
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                result.AppendLine(line);
            }

            return result.ToString();
        }
        else
        {
            return "File not found.";
        }
    }
    static void DisplayScore(List<BaseGoal> goals)
{
    int totalScore = 0;

    foreach (BaseGoal goal in goals)
    {
      
        if (int.TryParse(goal.GetTotalPoints(), out int goalScore))
        {
            totalScore += goalScore;
        }
        else
        {
            Console.WriteLine($"Error: Unable to convert goal score '{goal.GetTotalPoints()}' to an integer.");
        }
    }

    Console.WriteLine($"Total Score: {totalScore}");
}

}
