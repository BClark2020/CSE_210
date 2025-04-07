class Cycle : Activity
{

    private double _speed;
    public Cycle(double cycleSpeed, int minutes, string date)
    : base(minutes, date)
    {
        _speed = cycleSpeed;
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