using System;

class Program
{
    static void Main(string[] args)
    {
        bool continueRunning = true;
        while (continueRunning)
        {
            DisplayMenu();

            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    Goal newGoal = new Goal();
                    newGoal.Run();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;

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
    }

    static void ListGoals()
    {
        Console.WriteLine("List of Goals:");
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"[ ] {goal.GetGoalName()}");
        }
    }
}