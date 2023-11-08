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

                switch (choice)
                {
                    case "1":
                        Breathing activityBreathing = new Breathing();
                        activityBreathing.Run();
                        break;

                    case "2":
                        Reflection activityReflection = new Reflection();
                        activityReflection.DisplayActivities();
                        activityReflection.DisplayQuestions();
                        break;

                    case "3":
                        Listing activity = new Listing();
                        activity.DisplayRandomQuestion();
                        break;
                    
                    case "5":
                        continueRunning = false;
                        break;

                    default:
                        Console.WriteLine("Choose another option");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. ListingActivity");
            Console.WriteLine("5. Quit");
            Console.WriteLine("\nWhat would you like to do: ");
                
    }
}