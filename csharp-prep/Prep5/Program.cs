using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        double value1 = SquareNumber(userNumber);
        Console.Write($"{userName}, the square of your number is {value1}");
    }
    static void DisplayWelcome() 
    {
        Console.Write("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static double SquareNumber(double userNumber)
    {
        double value1 = Math.Pow(userNumber, 2);
        return value1;
    }

}