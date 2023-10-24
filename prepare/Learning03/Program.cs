using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction  f = new Fraction();
        f.SetFraction(1,2);
        Console.WriteLine(f.GetTop());
        Console.WriteLine(f.GetBottom());
    }
}