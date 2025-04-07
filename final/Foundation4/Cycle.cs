class Cycle: Activity
{

    private double _speed;
    public Cycle(double _cycle_speed, int _minutes, string _date)
    :base(_minutes, _date)
    {
        _speed = _cycle_speed;
    }
    
    public override string Summary()
    {
        string _summary = $"{GetDate()} Cycling({GetTime()} min) - Distance {(_speed / 60)*GetTime():0.00} miles, Speed {_speed} mph, Pace {60/_speed:0.00} min per mile";
        return _summary;
    }
}