class Swim : Activity
{
    private int _laps;
    public Swim(int _dist_laps, int _minutes, string _date)
    :base(_minutes, _date)
    {
        _laps = _dist_laps;
    }
    
    public override string Summary()
    {
        string _summary = $"{GetDate()} Swimming ({GetTime()} min) - Distance {((_laps * 50)/1000 *0.62)} miles ({_laps} laps), Speed {(((_laps * 50)/1000 *0.62) / GetTime()) * 60} mph, Pace {(GetTime())/((_laps * 50)/1000 *0.62):0.00} min per mile";
        return _summary;
    }
}