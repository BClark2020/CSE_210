using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

class Program
{
    public List<(Video, Comment)> _videos = new List<(Video, Comment)>();
    static void Main(string[] args)
    {
        Program _program = new Program(); 
        _program.SetupExamples();
        _program.Menu(); 
        Console.WriteLine("Thank you for using my prgram! Have a great day! (~^-^)~");
    }
    
    public void Menu()
    {
        while(true)
        {
            string _option = "";
            Console.Clear();
            Console.Write("Enter a numer\n1.) Add Video\n2.) Display Videos\n3.) Quit\nOption: ");
            _option = Console.ReadLine();
            
            switch (_option)
            {
                case "1":
                    AddNewVideo();
                break;
                
                case "2":
                    DisplayVideos();
                break;
                
                case "3":
                return;
                
                default:
                    Console.WriteLine("ERROR: input not recognized.");
                    Thread.Sleep(2000);
                break;
                
            }
        }   
    }
    
    
    private void DisplayVideos()
    {
        Console.Clear();
        for (int i = 0; i < _videos.Count; i++)
        {
            Video _vid = _videos[i].Item1;
            Comment _com = _videos[i].Item2; 
            _vid.DisplayInfo();
            _com.DisplayInfo();
            Console.WriteLine("\n---------------------");
        }
        Console.WriteLine("Press enter to leave.");
        string _wait = Console.ReadLine();
    }
    
    private void AddNewVideo()
    {
        Video _video = new Video();
        Comment _comment = new Comment();
                    
        // Get and save title
        Console.Write("Enter video title: ");
        string _title = Console.ReadLine();
        _video.SetTitle(_title);
                    
        // Get and save author
        Console.Write("Enter the author of the video: ");
        string _author = Console.ReadLine();
        _video.SetAuthor(_author);
                 
                    
        // Get and save length
        bool _var = false;
        do
        {
            try
            {
                Console.Write("Enter video length in seconds: ");
                int _length = int.Parse(Console.ReadLine());
                _video.SetLength(_length);
                _var = false;
            } catch (FormatException)
            {
                Console.WriteLine("\nFORMAT ERROR: Please enter an integer representing the lengh of the video in seconds.");
                _var = true;
            }
        }while(_var);
                    
                    
        // edits the comment object 
        _var = true;
        while(_var)
        {
            Console.Clear();
            Console.WriteLine("Enter ' ' to leave.");
            Console.Write("Enter new comment: ");
            string _new_comment = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(_new_comment))
            {
                 _var = false;
            }
            else
            {
                Console.Write("Enter the name of commentor: ");
                string _new_name = Console.ReadLine();
                _comment.AddComment(_new_name, _new_comment);  
            }
        }
    
        // Saves eddited objects
        _videos.Add((_video, _comment));  
    }
    
    private void SetupExamples()
    {
        Video _vid1 = new Video();
        Comment _com1 = new Comment();
        Video _vid2 = new Video();
        Comment _com2 = new Comment();
        Video _vid3 = new Video();
        Comment _com3 = new Comment();
        Video _vid4 = new Video();
        Comment _com4 = new Comment();
        
        _vid1.SetTitle("Video 1");
        _vid1.SetAuthor("Author 1");
        _vid1.SetLength(100);
        _com1.AddComment("Name 11", "Comment 11");
        _com1.AddComment("Name 12", "Comment 12");
        _com1.AddComment("Name 13", "Comment 13");
        _com1.AddComment("Name 14", "Comment 14");
        _com1.AddComment("Name 15", "Comment 15");
        _videos.Add((_vid1, _com1));
        
        _vid2.SetTitle("Video 2");
        _vid2.SetAuthor("Author 2");
        _vid2.SetLength(200);
        _com2.AddComment("Name 21", "Comment 21");
        _com2.AddComment("Name 22", "Comment 22");
        _com2.AddComment("Name 23", "Comment 23");
        _com2.AddComment("Name 24", "Comment 24");
        _videos.Add((_vid2, _com2));
        
        _vid3.SetTitle("Video 3");
        _vid3.SetAuthor("Author 3");
        _vid3.SetLength(300);
        _com3.AddComment("Name 31", "Comment 31");
        _com3.AddComment("Name 32", "Comment 32");
        _com3.AddComment("Name 33", "Comment 33");
        _com3.AddComment("Name 34", "Comment 34");
        _videos.Add((_vid3, _com3));
        
        _vid4.SetTitle("Video 4");
        _vid4.SetAuthor("Author 4");
        _vid4.SetLength(400);
        _com4.AddComment("Name 41", "Comment 41");
        _com4.AddComment("Name 42", "Comment 42");
        _com4.AddComment("Name 43", "Comment 43");
        _com4.AddComment("Name 44", "Comment 44");
        _com4.AddComment("Name 45", "Comment 45");
        _videos.Add((_vid4, _com4));
    }
}

// I want to be able to save instances of these classes as to mroe efficently save the required information
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