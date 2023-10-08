using System;

class Program
{
    static void Main(string[] args)
    {
        bool continueRunning = true;
        Prompter prompter = new Prompter();

            while (continueRunning)
            {
                DisplayMenu();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        prompter.randomOption();
                        break;

                    case "2":
                        prompter.DisplayTime();
                        break;

                    case "3":
                        prompter.Load();
                        break;
                    
                    case "4":
                        prompter.Save();
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
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("\nWhat would you like to do: ");
                
    }
}