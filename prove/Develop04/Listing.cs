public class Listing : Activity
{
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    public List<string> _questionOptions = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private int _listingDuration;

    public void StartingListing()
    {
        Console.WriteLine("Welcome to the Listing Activity");
        Console.WriteLine(_description);

       _listingDuration = GetDurationFromUser();
        
        GetReady();
    }
    public void DisplayRandomQuestion()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");

        Random random = new Random();
        int randomIndex = random.Next(_questionOptions.Count);
        string randomQuestion = _questionOptions[randomIndex];

        Console.WriteLine($" --- {randomQuestion} --- ");

        BeginIn();

        int duration = _listingDuration;
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string userResponse = Console.ReadLine();
        }

        // Display a message indicating that the time is up
        FinishingMessage();
        Console.WriteLine($"You have completed another {_listingDuration} secondsof the Listing Activity");
    }
}
