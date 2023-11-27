public class Goal
{
    bool MenuRun = true;

    public void Run()
    {
        while (MenuRun)
        {
            ShowMenu();
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    BasicGoal goal = new BasicGoal();
                    goal.Name();
                    goal.SumPoints();
                    goal.Save();
                    
                    break;
                case "2":
                    // Implement code for other goal types if needed
                    break;
                case "3":
                    // Implement code for other goal types if needed
                    break;
                case "4":
                    // Implement code for other goal types if needed
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. CheckLiest Goal");
        Console.WriteLine("Which type of goal would you like to create?");
    }
}
