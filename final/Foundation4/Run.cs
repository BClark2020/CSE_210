using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Run : Activity
{
    private double _distance;
    public Run(double _dist, int _minutes, string _date)
    :base( _minutes, _date)
    {
        _distance = _dist;
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