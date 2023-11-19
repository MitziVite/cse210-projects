public class Breathing : Activity
{
    private string _description = "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public void Run()
    {
    Console.WriteLine("Welcome to the Breathing Activity!");
    Console.WriteLine(_description);
    int totalDuration = GetDurationFromUser();
    GetReady();
    int remainingDuration = totalDuration;

    while (remainingDuration > 0)
    {
        // Clear the console
        Console.Clear();

        // Breathe in
        Console.WriteLine("Breathe in...");
        Animation(5); // Adjust this value based on your desired duration for "Breathe in"
        remainingDuration -= 5;

        if (remainingDuration <= 0)
            break;

        // Breathe out
        Console.WriteLine("Breathe out...");
        Animation(5); // Adjust this value based on your desired duration for "Breathe out"
        remainingDuration -= 5;

        // If the remaining duration is zero or negative, break out of the loop
        if (remainingDuration <= 0)
            break;
    }
    FinishingMessage();
    Console.WriteLine($"You have completed {totalDuration} seconds of the Breathing Activity");
}


}