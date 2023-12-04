using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class BaseGoal
{
    protected string goalName;
    protected string goalDescription;
    protected int totalPoints;
    protected static HashSet<string> uniqueGoalNames = new HashSet<string>();

    public virtual void Name()
    {
        do
        {
            Console.WriteLine("What is the name of the goal?");
            goalName = Console.ReadLine();

            if (uniqueGoalNames.Contains(goalName))
            {
                Console.WriteLine("Goal name already exists. Please enter a unique goal name.");
            }
            else
            {
                uniqueGoalNames.Add(goalName);
                break;
            }

        } while (true);

        Console.WriteLine("What is a short description of it? ");
        goalDescription = Console.ReadLine();
    }

    public virtual void SumPoints()
    {
        Console.WriteLine("What is the amount of points associated with this goal?");
        int pointValue;
        while (!int.TryParse(Console.ReadLine(), out pointValue))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for points.");
        }
        totalPoints += pointValue;
    }

    public virtual void Save()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string fileName = Console.ReadLine();

        if (!fileName.EndsWith(".txt"))
        {
            fileName += ".txt";
        }

        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            writer.WriteLine($"{GetGoalType()}: {goalName}, {goalDescription}, {totalPoints}, {IsCompleted()}");
        }

        Console.WriteLine($"Text saved in {fileName}");
    }

    // public virtual void Load()
    // {
    //     Console.Write("What is the name of the file you want to load:  ");
    //     string readFile = Console.ReadLine();
    //     string fileName = readFile + ".txt";

    //     if (File.Exists(fileName))
    //     {
    //         string[] lines = File.ReadAllLines(fileName);

    //         foreach (string line in lines)
    //         {
    //             string[] parts = line.Split(',');

    //             if (parts.Length == 4)
    //             {
    //                 goalName = parts[1].Trim();
    //                 goalDescription = parts[2].Trim();

    //                 if (int.TryParse(parts[3].Trim(), out int points))
    //                 {
    //                     totalPoints = points;
    //                 }
    //                 else
    //                 {
    //                     Console.WriteLine("Error parsing totalPoints.");
    //                 }
    //             }
    //             else
    //             {
    //                 Console.WriteLine("Error reading line: " + line);
    //             }
    //         }

    //         Console.WriteLine("File loaded successfully.");
    //     }
    //     else
    //     {
    //         Console.WriteLine("File not found.");
    //     }
    // }

    public virtual string Load()
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


    public virtual void DisplayTotalPoints()
    {
        Console.WriteLine($"You have {totalPoints} points");
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine("Event recorded for the goal.");
    }

    public virtual string GetGoalName()
    {
        return goalName;
    }

    public virtual bool IsCompleted()
    {
        return false;
    }

    public virtual string GetGoalDescription()
    {
        return goalDescription;
    }

    public virtual int GetTimesCompleted()
    {
        return 0;
    }

    public virtual int GetTimesToAccomplish()
    {
        return 0;
    }

    public virtual string GetGoalType()
    {
        return "BaseGoal";
    }

    public virtual string GetTotalPoints(){
        return totalPoints.ToString();
    }

    public virtual string SaveGoalInfo()
{
    return $"{GetType().Name}: {goalName}, {goalDescription}, {totalPoints}, {IsCompleted()}";
}

}
