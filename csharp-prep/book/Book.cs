public class Book
{
    private string _author;
    private string _name;
    private int _timesRead;
    private bool _available;

    public Book(string name, string author)
    {
        _author = author;
        _name = name;
        _timesRead = 0;
        _available = true;
    }

    public void Display()
    {
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Times Read {_timesRead}");
        Console.WriteLine($"Available {_available}");
    }

    public bool HasAuthor(string author)
    {
        return _author.Contains(author);
    }
    public void Checkout()
    {
        (if !_available)
        {
            return false;
        }
    }

    public void 
}