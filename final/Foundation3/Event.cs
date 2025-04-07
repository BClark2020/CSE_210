using System.Runtime.CompilerServices;

abstract class Event
{
    private string _title = "Best event ever probably";
    private string _decription = "Best event ever probably";
    private string _date = "never i guess";
    private Address _addrs;
    
    public Event(string eventTitle, string eventDescription, string eventDate, Address eventAddrs)
    {
        _title = eventTitle;
        _decription = eventDescription;
        _date = eventDate;
        _addrs = eventAddrs;
    }
    
    public string GetTitle()
    {
        return _title;
    }
    public string GetDate()
    {
        return _date;
    }
    
    public string DisplayStandardDetails()
    {
        string standard = $"Event title: {_title}";
        standard += $"\nDate: {_date}";
        standard += $"\nDescription: {_decription}";
        standard += "\n----Address----\n";
        standard += _addrs.GetAddress();
        return standard;
    }
    
    public abstract string DisplayShortDescription();
    public abstract string DisplayFullDetails();
    
    
}