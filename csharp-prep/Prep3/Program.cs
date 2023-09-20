using System;

class Program
{
    static void Main(string[] args)
    {


        Random rnd = new Random();

        int num = rnd.Next(1,10);
        int guessNumber;
        do{
            Console.WriteLine("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber > num ) 
            {
                Console.WriteLine("Lower");
            }
            else if ( guessNumber < num )
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber == num)
            {
            Console.WriteLine("You guessed it");
        }

    } while (guessNumber != num); 
    }
}