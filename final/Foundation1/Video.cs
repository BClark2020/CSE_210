
class Video
{

    // create a class with its respective variables
    // all these variables will change so I like to have fun initilizations 
    private string _title = "A really awesome video";
    private string _author = "Some really cool dude I imagine";
    private int _length_seconds = 1000000;
    private string _length_mintues = "I don't even know what that is";

    public void SetTitle(string _entered_title)
    {
        _title = _entered_title; 
    }
    
    public void SetAuthor(string _entered_author)
    {
        _author = _entered_author; 
    }
       
    public void SetLength(int _entered_length)
    {
        _length_seconds = _entered_length; 
        _length_mintues = $"{_length_seconds/60}:";
        if (_length_seconds%60 == 0)
        {
            _length_mintues += "00";
        }
        else
        {
            _length_mintues += $"{_length_seconds%60}";
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length in seconds: {_length_seconds}");
        Console.WriteLine($"Length in Minutes: {_length_mintues}"); 
    }
}
