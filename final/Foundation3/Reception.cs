class Reception : Event
{

    private string _rsvp = "blah_blah_blah123@something.org";
    
    public Reception(string _title, string _description, string _date, Address _addrs, string _event_rsvp)
    : base(_title, _description, _date, _addrs)
    {
        _rsvp = _event_rsvp;
    }
    
    public override string DisplayFullDetails()
    {
        string _ad = "Event type: Reception\n";
        _ad += $"RSVP Email: {_rsvp}\n";
        _ad += DisplayStandardDetails();
        return _ad;
    }
     public override string DisplayShortDeescription()
    {
        string _ad = "Event type: Reception";
        _ad += $"\nTitle: {GetTitle()}";
        _ad += $"\nDate: {GetDate()}";
        return _ad;
    }
    
}