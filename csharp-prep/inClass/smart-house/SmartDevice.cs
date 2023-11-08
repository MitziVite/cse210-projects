public class  SmartDevice
{
    protected string _room;
    protected bool _isOn;
    protected int _time;

    public SmartDevice (string room)
    {
        _room = room;
        _isOn = false;
    }

    public void TurnOn()
    {
        if (!_isOn){
            _isOn = true;
        }
    }

    public void CheckStatus()
    {
        if (_isOn)
        {
            Console.WriteLine("The device is on");
        }
        else
        {
            Console.WriteLine("The device is off");
        }
    }



    
}