public class Listing : Activity{
    private string _description="This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    public List<string> _questionOptions = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    
    public void DisplayRandomQuestion()
    {
        Console.WriteLine(_description);

        Random random = new Random();
        int randomIndex = random.Next(_questionOptions.Count);

        string randomQuestion = _questionOptions[randomIndex];
        Console.WriteLine($"{randomQuestion}");
    }
}