public class Player
{
    private string _name;
    private int _iNumber;

    public Player(string name, int jersey)
    {
        _name = name;
        _iNumber = jersey;
    }

    public void Display(){
        Console.WriteLine($"{_name} {_iNumber}");
    }
}