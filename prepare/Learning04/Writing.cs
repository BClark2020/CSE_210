class Writing : Assignment{
    private string _title;
    
    public Writing(string _student, string _topic, string _book) : base(_student , _topic)
    {
        _title = _book;
    }
    
    public string GetWritingInformation()
    {
        string _student = GetStudent();
        return _title + " by " + _student;
    }
}