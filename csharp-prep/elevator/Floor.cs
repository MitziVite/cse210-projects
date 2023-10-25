public class Floor
{
    private int _floorNumber;
    private bool _vipFloor;
    public Floor (int floorNumber)
    {
        _floorNumber = floorNumber;
        _vipFloor = false;
    }
    public Floor (int floorNumber, bool _vipFloor)
    {
        _floorNumber = floorNumber;
        _vipFloor = _vipFloor;
    }
    public void DisplayFloor(){
        Console.WriteLine($"You are in floor{_floorNumber}");
    }
}