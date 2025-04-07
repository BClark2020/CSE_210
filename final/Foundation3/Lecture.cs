class Lecture : Event 
{
    private string _speaker = "Bill Murray";
    private int _capacity = 100;
    
    public Lecture( string _event_title, string _event_description, string _event_date, 
    Address _event_addrs, string _event_speaker, int _event_capacity) 
    : base(_event_title, _event_description, _event_date, _event_addrs)
    {
        _speaker = _event_speaker;
        _capacity = _event_capacity;
    }

    public override string DisplayFullDetails()
    {
        string _ad = "Event type: Lecture\n";
        _ad += $"Speaker: {_speaker}";
        _ad += $"\nCapacity: {_capacity}\n";
        _ad += DisplayStandardDetails();
        return _ad;  
    }

    public override string DisplayShortDeescription()
    {
        string _ad = "Event type: Lecture";
        _ad += $"\nTitle: {GetTitle()}";
        _ad += $"\nDate: {GetDate()}";
        return _ad;
    }
}