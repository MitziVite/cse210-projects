using System;

class Program
{
    static void Main(string[] args)
    {
        bool continueRunning = true;
            while (continueRunning)
            {
                // Console.Clear();
                DisplayMenu();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Breathing activityBreathing = new Breathing();
                        activityBreathing.Run();
                        break;

                    case "2":
                        Console.Clear();
                        Reflection activityReflection = new Reflection();
                        activityReflection.initializeReflection();
                        activityReflection.DisplayActivities();
                        activityReflection.DisplayQuestions();

                        break;

                    case "3":
                        Console.Clear();
                        Listing activity = new Listing();
                        activity.StartingListing();
                        activity.DisplayRandomQuestion();
                        break;
                    
                    case "4":
                        continueRunning = false;
                        break;

                    default:
                        Console.WriteLine("Choose another option");
                        Console.ReadLine();
                        break;
                }
                
            }
            // Console.Clear();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("\nWhat would you like to do: ");
        }
}