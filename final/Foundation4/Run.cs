using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Run : Activity
{
    private double _distance;
    public Run(double dist, int minutes, string date)
    : base(minutes, date)
    {
        _distance = dist;
    }


    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetTime()) * 60;
    }

    public override double GetPace()
    {
        return GetTime() / _distance;
    }
}