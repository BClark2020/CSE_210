class Comment
{
    private List<(string, string)> _comments = new List<(string, string)>();
    public void AddComment(string _name, string _comment)
    {
        _comments.Add((_name, _comment));
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Number of comments: {_comments.Count()}");
        Console.WriteLine("------- COMMENTS -------");
        for(int i = 0; i < _comments.Count(); i++)
        {
            Console.WriteLine($"\nName: {_comments[i].Item1}");
            Console.WriteLine($"{_comments[i].Item2}");
        }  
    }
}