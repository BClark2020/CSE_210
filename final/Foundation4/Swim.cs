class Swim : Activity
{
    private int _laps;
    public Swim(int distLaps, int minutes, string date)
    :base(minutes, date)
    {
        _laps = distLaps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62; // meters to kilometers to miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetTime()) * 60;
    }

    public override double GetPace()
    {
        return GetTime() / GetDistance();
    }
}