using System;
using System.Collections.Generic;
using System.IO;
public class Prompter
{ 
    public string _answer;
    public string _randomOption;
    
    public List<string> _writeOptions = new List<string>(){
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    private List<string> _answers = new List<string>();

    // public List<Entry> _jobs = new List<Entry>();    

    public void randomOption()
    {
        Random random = new Random();
        _randomOption = _writeOptions[random.Next(_writeOptions.Count)];
        Console.WriteLine(_randomOption);
        string userAnswer = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        _answers.Add($"{_randomOption}: {userAnswer} {dateText}");
    }

    public void DisplayTime()
    {
        foreach (string answer in _answers)
        {
            Console.WriteLine(answer);
        }
    }

    public void Save()
    {
        Console.Write("What is the name of the file? (without .txt): ");
        string userInput = Console.ReadLine();
        string fileName = $"{userInput}.txt";

        using (StreamWriter sw = new StreamWriter(fileName))
    {
        foreach (string answer in _answers)
        {
            sw.WriteLine(answer);
        }
    }

        Console.WriteLine($"Las respuestas se han guardado en {fileName}");
    }


    public void Load(){
        Console.Write("What is the name of the file you want to load:  ");
        string readFile = Console.ReadLine();
        string fileName = readFile + ".txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);
        int numberOfLines = lines.Length;
        
        foreach (string line in lines)
        {
            _answers.Add(line);
        }
    }


    
}