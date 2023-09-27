public class Team
{
    private string _name;
    private List<Player> _roster = new List<Player>();
    private int _wins = 0;
    private int _looses = 0;

    public Team(string name)
    {
        _name = name;
    }

    public void AddPlayer(Player p)
    {
        _roster.Add(p);
    }

    public void AddWin()
    {
        _wins++;
    }

    public void AddLosses()
    {
        _looses++;
    }

    public void DisplayRoster()
    {
        Console.WriteLine();
        Console.WriteLine(_name);
        Console.WriteLine($"Wins: {_wins} Looses:{_looses}");
        Console.WriteLine("-----------------------------------");
        foreach (Player p in _roster)
        {
            p.Display();
        }
        Console.WriteLine();

    }


    public string GetTeamNumber()
    {
        return _name;
    }
}