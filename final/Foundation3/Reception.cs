class Reception : Event
{

    private string _rsvp = "blah_blah_blah123@something.org";
    
    public Reception(string title, string description, string date, Address addrs, string eventRsvp)
    : base(title, description, date, addrs)
    {
        _rsvp = eventRsvp;
    }
    
    public override string DisplayFullDetails()
    {
        string ad = "Event type: Reception\n";
        ad += $"RSVP Email: {_rsvp}\n";
        ad += DisplayStandardDetails();
        return ad;
    }
     public override string DisplayShortDescription()
    {
        string ad = "Event type: Reception";
        ad += $"\nTitle: {GetTitle()}";
        ad += $"\nDate: {GetDate()}";
        return ad;
    }
    
}