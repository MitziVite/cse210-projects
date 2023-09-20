using System;
using System.Collections.Generic;
using System.Linq;
class Program

{
    static void Main(string[] args)
    
    {
        
        List<int> numbers = new List<int>();
        int userNumber;
        
        do{
        Console.WriteLine("Enter number");
        userNumber = int.Parse(Console.ReadLine());
        if (userNumber != 0)
    {
        numbers.Add(userNumber);
    }
        }while (userNumber != 0);

        int total = 0;
        
        
        foreach (int number in numbers)
        {
            total += number;
            
        }
        double avg = (double)total / numbers.Count;
        int maxNumber = numbers.Max();
        Console.WriteLine($"The sum is {total}");
        Console.WriteLine($"The Average is {avg}");
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}