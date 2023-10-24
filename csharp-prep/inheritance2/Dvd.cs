public class Dvd : Lonable
{
    // private string _title;
    public Dvd(string title)
    {
        _title = title;
    }

    public override void Display()
    {
        Console.WriteLine($"Title: {_title}");
        base.Display();
    }
}