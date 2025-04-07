using System.Reflection.Metadata.Ecma335;

class Activity
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

    public virtual string Summary()
    {
        string _summary = "";
        return _summary;
    }
}