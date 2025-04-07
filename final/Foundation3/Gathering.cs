using System.Net.Sockets;
class Gathering : Event
{
    private string _weather = "Hopefully not raining";
    public Gathering(string _title, string _description, string _date, Address _addrs, string _event_weather)
    : base(_title, _description, _date, _addrs)
    {
        _weather = _event_weather;
    }
    
    public override string DisplayFullDetails()
    {
        string _ad = "Event type: Gathering\n";
        _ad += $"Weather Forcast: {_weather}\n";
        _ad += DisplayStandardDetails();
        return _ad;
    }
     public override string DisplayShortDeescription()
    {
        string _ad = "Event type: Gathering";
        _ad += $"\nTitle: {GetTitle()}";
        _ad += $"\nDate: {GetDate()}";
        return _ad;
    }
}