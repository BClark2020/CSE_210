public class Mindfullness_app
{
    public int _BCtimer; 

   public string Menu()
   {
    Console.Clear();
    string activity = "";
    List<string> _BCaccepted_values = new List<string>{"2","listing", "listing activity", "1", "reflection", "reflection activity", "3", "meditation", "meditation activity",
    "4", "affirmation", "affirmations", "affirmation activity", "affirmations activity", "5", "quit", "q"};


    Console.WriteLine("Welcome to the mindfullness app!");
    Console.WriteLine("What would you like to do:\n1.) Reflection Activity");
    Console.WriteLine("2.) Listing Activity\n3.) Meditation Activity\n4.) Affirmation Activity");
    Console.WriteLine("5.) Quit");


    bool _BCbool = false;
    do
    {
        try
        {
            activity = Console.ReadLine().ToLower();
            _BCbool = false;
            if (!_BCaccepted_values.Contains(activity))
            {
                throw new Exception();
            }

        }

        catch (Exception)
        {
            Console.WriteLine("Error, input not recognized.");
            _BCbool = true; 
        }
    }while(_BCbool);


    set_timer();

    loading();

    if (activity == "listing" || activity == "listing activity" || activity == "2")
    {
        Listing List = new Listing();
        List.program(_BCtimer);
        activity = "2";
    }

    else if (activity == "reflection"||  activity == "reflection activity" || activity == "1" )
    {
       Reflection reflect = new Reflection(); 
       reflect.program(_BCtimer);
       activity = "1";
    }
    
    else if (activity == "3" || activity == "meditation" || activity == "meditation activity")
    {
        Meditation meditate = new Meditation();
        meditate.program(_BCtimer);
        activity = "3";
    }

    else if (activity == "4"|| activity == "affirmation"|| activity == "affirmations"|| activity == "affirmation activity"||activity == "affirmations activity")
    {
        Affirmations affirm = new Affirmations(); 
        affirm.program(_BCtimer);
        activity = "4";
    }
    else
    {
        activity = "5";  
    }
    return activity;
   }

    private void set_timer()
    {
        bool _BCbool = false;
        do
        {
            try
            {
            Console.WriteLine("How long would you like to do this activity(in seconds)?");
            string input = Console.ReadLine();
            _BCtimer = int.Parse(input);
            _BCbool = false;
            }
            catch (FormatException)
            {
            Console.WriteLine("Please enter an integer.");
            _BCbool = true;
            }

        }while(_BCbool);



    }
    public void loading()
    {
        Console.Clear();
        int repetions = 8;
        for (int i = 0; i < repetions; i++)
        {
        Console.Write("\b\b\b\b\b\b\b\b\bLoading |");
        Thread.Sleep(75);
        Console.Write("\b\b\b\b\b\b\b\b\bLoading /");
        Thread.Sleep(75);
        Console.Write("\b\b\b\b\b\b\b\b\bLoading —");
        Thread.Sleep(75);
        Console.Write("\b\b\b\b\b\b\b\b\bLoading \\");
        Thread.Sleep(75);
        Console.Write("\b\b\b\b\b\b\b\b\bLoading |");
        Thread.Sleep(75);
        Console.Write("\b\b\b\b\b\b\b\b\bLoading /");
        Thread.Sleep(75);
        Console.Write("\b\b\b\b\b\b\b\b\bLoading —");
        Thread.Sleep(75);
        Console.Write("\b\b\b\b\b\b\b\b\bLoading \\");
        Console.Write("\b\b\b\b\b\b\b\b\b");
        }
    }
    public void spinner(int repetitions = 1)
    {

        for (int i = 0; i < repetitions; i++)
        {
        Console.Write("\b|");
        Thread.Sleep(112);
        Console.Write("\b/");
        Thread.Sleep(112);
        Console.Write("\b—");
        Thread.Sleep(112);
        Console.Write("\b\\");
        Thread.Sleep(112);
        Console.Write("\b|");
        Thread.Sleep(112);
        Console.Write("\b/");
        Thread.Sleep(115);
        Console.Write("\b—");
        Thread.Sleep(115);
        Console.Write("\b\\");
        Console.Write("\b");
        }
    }
}