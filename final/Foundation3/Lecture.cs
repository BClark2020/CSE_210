class Lecture : Event 
{
    private string _speaker = "Bill Murray";
    private int _capacity = 100;
    
    public Lecture( string eventTitle, string eventDescription, string eventDate, 
    Address eventAddrs, string eventSpeaker, int eventCapacity) 
    : base(eventTitle, eventDescription, eventDate, eventAddrs)
    {
        _speaker = eventSpeaker;
        _capacity = eventCapacity;
    }

    public override string DisplayFullDetails()
    {
        string ad = "Event type: Lecture\n";
        ad += $"Speaker: {_speaker}";
        ad += $"\nCapacity: {_capacity}\n";
        ad += DisplayStandardDetails();
        return ad;  
    }

    public override string DisplayShortDescription()
    {
        string ad = "Event type: Lecture";
        ad += $"\nTitle: {GetTitle()}";
        ad += $"\nDate: {GetDate()}";
        return ad;
    }
}