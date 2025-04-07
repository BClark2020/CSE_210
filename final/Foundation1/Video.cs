
class Video
{

    // create a class with its respective variables
    // all these variables will change so I like to have fun initilizations 
    private string _title = "A really awesome video";
    private string _author = "Some really cool dude I imagine";
    private int _lengthSeconds = 1000000;
    private string _lengthMintues = "I don't even know what that is";

    public void SetTitle(string enteredTitle)
    {
        _title = enteredTitle;
    }

    public void SetAuthor(string enteredAuthor)
    {
        _author = enteredAuthor;
    }

    public void SetLength(int enteredLength)
    {
        _lengthSeconds = enteredLength;
        _lengthMintues = $"{_lengthSeconds / 60}:";
        if (_lengthSeconds % 60 == 0)
        {
            _lengthMintues += "00";
        }
        else
        {
            _lengthMintues += $"{_lengthSeconds % 60}";
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length in seconds: {_lengthSeconds}");
        Console.WriteLine($"Length in Minutes: {_lengthMintues}");
    }
}
