using System.Net.Sockets;
class Gathering : Event
{
    private string _weather = "Hopefully not raining";
    public Gathering(string title, string description, string date, Address addrs, string eventWeather)
    : base(title, description, date, addrs)
    {
        _weather = eventWeather;
    }
    
    public override string DisplayFullDetails()
    {
        string ad = "Event type: Gathering\n";
        ad += $"Weather Forcast: {_weather}\n";
        ad += DisplayStandardDetails();
        return ad;
    }
     public override string DisplayShortDescription()
    {
        string ad = "Event type: Gathering";
        ad += $"\nTitle: {GetTitle()}";
        ad += $"\nDate: {GetDate()}";
        return ad;
    }
}