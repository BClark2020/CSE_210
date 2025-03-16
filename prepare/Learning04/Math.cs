class Math : Assignment{
    
    private string _textbook;
    private string _problems;
    
    public Math(string _student, string _topic, string _chapters, string _problemNumbers) : base(_student, _topic)
    {       
        _textbook = _chapters;
        _problems = _problemNumbers;
    }
    
    public string GetHomeworkList()
    {
        string _list = "Section: " + _textbook + "   " + "Problems: " + _problems;
        return _list;
    }
}