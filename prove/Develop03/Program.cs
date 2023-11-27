class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Reference nref = new Reference("Alma", "15", "17");
        nref.Display();
        Scripture nscrip = new Scripture("Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise.");
        nscrip.Display();

        while (true)
        {
            Console.WriteLine("\nType any key ('Q' to exit)");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            nscrip.HideRandomWord();
            Console.Clear();
            nref.Display();
            nscrip.Display();

            if (nscrip.AllWordsHidden()|| keyInfo.Key == ConsoleKey.Q)
            {
                break;
            }
        }
    }
}
