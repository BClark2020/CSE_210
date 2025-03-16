using System.Runtime.CompilerServices;

class Assignment{

    private string _student;
    private string _topic;
    
    public string GetStudent()
    {
        return _student;
    }
    public string GeTopic()
    {
        return _topic;
    }
    public Assignment(string _name, string _subject)
    {
        _student = _name;
        _topic = _subject;
    }
    public string GetSummary()
    {
        string summary = _student + " - " + _topic;
        return summary;  
    }
    
}