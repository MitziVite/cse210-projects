public class Breathing : Activity
{
    private string _description = "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    
    public void Run()
    {
        Console.WriteLine("Welcome to the Relaxation Activity!");
        int duration = GetDurationFromUser();
        
        Console.WriteLine(_description);

        while (duration > 0)
        {
            Console.WriteLine("Breathe in...");
            Countdown(duration);
            duration--;

            if (duration <= 0)
                break;

            Console.WriteLine("Breathe out...");
            Countdown(duration);
            duration--;
        }

        Console.WriteLine("Relaxation Activity completed. Take a moment to clear your mind and relax.");
    }

    private int GetDurationFromUser()
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

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Time remaining: {i} seconds");
            Thread.Sleep(1000); // Pause for 1 second
        }
    }
}
