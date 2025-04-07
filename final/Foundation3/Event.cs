using System.Runtime.CompilerServices;

abstract class Event
{
    private string _title = "Best event ever probably";
    private string _decription = "Best event ever probably";
    private string _date = "never i guess";
    private Address _addrs;
    
    public Event(string _event_title, string _event_description, string _event_date, Address _event_addrs)
    {
        _title = _event_title;
        _decription = _event_description;
        _date = _event_date;
        _addrs = _event_addrs;
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
        string _standard = $"Event title: {_title}";
        _standard += $"\nDate: {_date}";
        _standard += $"\nDescription: {_decription}";
        _standard += "\n----Address----\n";
        _standard += _addrs.GetAddress();
        return _standard;
    }
    
    public abstract string DisplayShortDeescription();
    public abstract string DisplayFullDetails();
    
    
}