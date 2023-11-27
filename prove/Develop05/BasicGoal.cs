using System;
using System.Collections.Generic;
using System.IO;

public class BasicGoal
{
    private string goalName;
    private string goalDescription;
    private int totalPoints;
    private static HashSet<string> uniqueGoalNames = new HashSet<string>();

    public void Name()
    {
        do
        {
            Console.WriteLine("What is the name of the goal?");
            goalName = Console.ReadLine();

            // Check if the goal name already exists
            if (uniqueGoalNames.Contains(goalName))
            {
                Console.WriteLine("Goal name already exists. Please enter a unique goal name.");
            }
            else
            {
                // Add the goal name to the collection if it's unique
                uniqueGoalNames.Add(goalName);
                break; // Exit the loop if the goal name is unique
            }

        } while (true);

        Console.WriteLine("What is a short description of it? ");
        goalDescription = Console.ReadLine();
    }

    public void SumPoints()
    {
        Console.WriteLine("What is the amount of points associated with this goal");
        int pointValue = int.Parse(Console.ReadLine());
        totalPoints += pointValue;
    }

    public void Save()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        if (!fileName.EndsWith(".txt"))
        {
            fileName += ".txt";
        }

        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            writer.WriteLine($" {goalName}, {goalDescription}, {totalPoints}");
        }

        Console.WriteLine("Text saved in " + fileName);
    }

    public void Load()
{
    Console.Write("What is the name of the file you want to load:  ");
    string readFile = Console.ReadLine();
    string fileName = readFile + ".txt";

    if (File.Exists(fileName))
    {
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            // Split the line using commas
            string[] parts = line.Split(',');

            if (parts.Length == 3)
            {
                // Assuming the order is: goalName, goalDescription, totalPoints
                goalName = parts[0].Trim();
                goalDescription = parts[1].Trim();

                if (int.TryParse(parts[2].Trim(), out int points))
                {
                    totalPoints = points;
                }
                else
                {
                    Console.WriteLine("Error parsing totalPoints.");
                }
            }
            else
            {
                Console.WriteLine("Error reading line: " + line);
            }
        }

        Console.WriteLine("File loaded successfully.");
    }
    else
    {
        Console.WriteLine("File not found.");
    }
}
}