public class Elevator
{
    private bool _open;
    private List<Floor> _availableFloors = new List<Floor>();
    private Floor _activeFloor;

    public Elevator()
    {
        // _activeFloor = activeFloor;
        _open = false;
    }

    public void AddFloorNumber(Floor floor)
    {
        _availableFloors.Add(floor);
    }

    public void ChangeFloor(Floor newFloor)
    {
        if(_open = false){
            Console.WriteLine("The door is open");
        }else{
            _activeFloor = newFloor;
        }
    }

    public void ChangeDoorStatus()
    {
        if(_open = false){
            _open = true;
        }else{
            _open = false;
        }

    }
    public void ShowFloor()
    {
        Console.Write("You are in floor number: ");
        foreach (Floor floor in _availableFloors){
            floor.DisplayFloor();
        }
    }
}