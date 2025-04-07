using System.Reflection.Metadata.Ecma335;

class Run : Activity
{
    private double _distance;
    public Run(double _dist, int _minutes, string _date)
    :base( _minutes, _date)
    {
        _distance = _dist;
    }

    public override string Summary()
    {
        string _summary = $"{GetDate()} Running({GetTime()} min) - Distance {_distance} miles, Speed {(_distance/GetTime())*60:0.00} mph, Pace {GetTime()/_distance:0.00} min per mile";
        return _summary;
    }
}