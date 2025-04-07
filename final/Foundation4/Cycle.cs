class Cycle: Activity
{

    private double _speed;
    public Cycle(double _cycle_speed, int _minutes, string _date)
    :base(_minutes, _date)
    {
        _speed = _cycle_speed;
    }
    
    public override double GetSpeed()
    {
        return _speed;
    } 

    public override double GetDistance()
    {
        return (_speed * GetTime()) / 60;
    }

    public override double GetPace()
    { 
        return 60 / _speed;
    }
}