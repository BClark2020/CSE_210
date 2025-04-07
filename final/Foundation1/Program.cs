using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

class Program
{
    public List<(Video, Comment)> _videos = new List<(Video, Comment)>();
    static void Main(string[] args)
    {
        Program program = new Program(); 
        program.SetupExamples();
        program.Menu(); 
        Console.WriteLine("Thank you for using my prgram! Have a great day! (~^-^)~");
    }
    
    public void Menu()
    {
        while(true)
        {
            string option = "";
            Console.Clear();
            Console.Write("Enter a numer\n1.) Add Video\n2.) Display Videos\n3.) Quit\nOption: ");
            option = Console.ReadLine();
            
            switch (option)
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
            Video vid = _videos[i].Item1;
            Comment com = _videos[i].Item2; 
            vid.DisplayInfo();
            com.DisplayInfo();
            Console.WriteLine("\n---------------------");
        }
        Console.WriteLine("Press enter to leave.");
        string wait = Console.ReadLine();
    }    
    
    private void AddNewVideo()
    {
        Video video = new Video();
        Comment comment = new Comment();
                    
        // Get and save title
        Console.Write("Enter video title: ");
        string title = Console.ReadLine();
        video.SetTitle(title);
                    
        // Get and save author
        Console.Write("Enter the author of the video: ");
        string author = Console.ReadLine();
        video.SetAuthor(author);
                 
                    
        // Get and save length
        bool var = false;
        do
        {
            try
            {
                Console.Write("Enter video length in seconds: ");
                int length = int.Parse(Console.ReadLine());
                video.SetLength(length);
                var = false;
            } catch (FormatException)
            {
                Console.WriteLine("\nFORMAT ERROR: Please enter an integer representing the lengh of the video in seconds.");
                var = true;
            }
        }while(var);
                    
                    
        // edits the comment object 
        var = true;
        while(var)
        {
            Console.Clear();
            Console.WriteLine("Enter ' ' to leave.");
            Console.Write("Enter new comment: ");
            string newComment = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newComment))
            {
                var = false;
            }
            else
            {
                Console.Write("Enter the name of commentor: ");
                string newName = Console.ReadLine();
                comment.AddComment(newName, newComment);  
            }
        }
    
        // Saves eddited objects
        _videos.Add((video, comment));  
    }
    
    private void SetupExamples()
    {
        Video vid1 = new Video();
        Comment com1 = new Comment();
        Video vid2 = new Video();
        Comment com2 = new Comment();
        Video vid3 = new Video();
        Comment com3 = new Comment();
        Video vid4 = new Video();
        Comment com4 = new Comment();
        
        vid1.SetTitle("Video 1");
        vid1.SetAuthor("Author 1");
        vid1.SetLength(100);
        com1.AddComment("Name 11", "Comment 11");
        com1.AddComment("Name 12", "Comment 12");
        com1.AddComment("Name 13", "Comment 13");
        com1.AddComment("Name 14", "Comment 14");
        com1.AddComment("Name 15", "Comment 15");
        _videos.Add((vid1, com1));
        
        vid2.SetTitle("Video 2");
        vid2.SetAuthor("Author 2");
        vid2.SetLength(200);
        com2.AddComment("Name 21", "Comment 21");
        com2.AddComment("Name 22", "Comment 22");
        com2.AddComment("Name 23", "Comment 23");
        com2.AddComment("Name 24", "Comment 24");
        _videos.Add((vid2, com2));
        
        vid3.SetTitle("Video 3");
        vid3.SetAuthor("Author 3");
        vid3.SetLength(300);
        com3.AddComment("Name 31", "Comment 31");
        com3.AddComment("Name 32", "Comment 32");
        com3.AddComment("Name 33", "Comment 33");
        com3.AddComment("Name 34", "Comment 34");
        _videos.Add((vid3, com3));
        
        vid4.SetTitle("Video 4");
        vid4.SetAuthor("Author 4");
        vid4.SetLength(400);
        com4.AddComment("Name 41", "Comment 41");
        com4.AddComment("Name 42", "Comment 42");
        com4.AddComment("Name 43", "Comment 43");
        com4.AddComment("Name 44", "Comment 44");
        com4.AddComment("Name 45", "Comment 45");
        _videos.Add((vid4, com4));
    }
}