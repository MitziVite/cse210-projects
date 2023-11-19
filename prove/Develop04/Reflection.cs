public class Reflection : Activity
{
    private int _totalDuration;
    private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    public List<string> _activityOptions = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public List<string> _questionOptions = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

      public void initializeReflection()
    {
        Console.WriteLine("Welcome to the Reflection Activity");
        Console.WriteLine(_description);

        // Almacena la duración total ingresada por el usuario
        _totalDuration = GetDurationFromUser();

        GetReady();
    }

    public void DisplayActivities()
    {
        Console.WriteLine("Consider the following prompt:");
        Random random = new Random();
        int randomIndex = random.Next(_activityOptions.Count);
        string randomActivity = _activityOptions[randomIndex];
        Console.WriteLine($" --- {randomActivity} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
         // Wait for the user to press the SPACE key
        while (Console.ReadKey().Key != ConsoleKey.Spacebar)
        {
            // Keep waiting until the user presses SPACE
        }
        Console.WriteLine(); // Move to the next line after SPACE is pressed
    }



    public void DisplayQuestions()
    {
        Console.WriteLine("Consider the following prompts:");

        int numberOfQuestions = _totalDuration / 10;
        int animationDuration = _totalDuration / numberOfQuestions;

        for (int i = 0; i < numberOfQuestions; i++)
        {
            Random random = new Random();
            int randomIndex = random.Next(_questionOptions.Count);
            string randomQuestion = _questionOptions[randomIndex];

            Console.WriteLine($"{i + 1}. {randomQuestion}");

            // Elimina la pregunta para evitar repeticiones
            _questionOptions.RemoveAt(randomIndex);

            // Duración de la animación ajustada al tiempo de una pregunta
            if (animationDuration <= 10)  // Asegúrate de que la animación no sea más larga que el intervalo
            {
                Animation(animationDuration);
                Thread.Sleep(10000 - animationDuration * 1000); // Espera el tiempo restante antes de la siguiente pregunta
            }
            else
            {
                Console.WriteLine("Error: La duración de la animación es mayor que el intervalo de espera.");
                break;
            }

        
        }
        Console.WriteLine($"You have completed {_totalDuration} seconds of the Reflection Activity");
    }





}