using System.Reflection.Metadata.Ecma335;

abstract class Activity
{

    private int _time_minutes;
    private string _date;

    
    public Activity(int _minutes, string _activity_date)
    {
        _time_minutes = _minutes;
        _date = _activity_date;
    }
    
    public int GetTime()
    {
        return _time_minutes; 
    }
    
    public string GetDate()
    {
        return _date;
    }
        public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string Summary()
    {
        return $"{_date} {this.GetType().Name} ({_time_minutes} min): " +
               $"Distance {GetDistance():0.0} miles, " +
               $"Speed {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min per mile";
    }
}