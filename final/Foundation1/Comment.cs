class Comment
{
    private List<(string, string)> _comments = new List<(string, string)>();
    public void AddComment(string name, string comment)
    {
        _comments.Add((name, comment));
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Number of comments: {_comments.Count()}");
        Console.WriteLine("------- COMMENTS -------");
        for (int i = 0; i < _comments.Count(); i++)
        {
            Console.WriteLine($"\nName: {_comments[i].Item1}");
            Console.WriteLine($"{_comments[i].Item2}");
        }
    }
}