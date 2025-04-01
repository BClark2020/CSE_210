public class Listing : Mindfullness_app
   {
    Mindfullness_app mind = new Mindfullness_app();
    Random random = new Random();
    private bool _BCbool = true;

    private List<string> prompts = new List<string>()
    {   
        "good attributes about yourself",
        "amazing things you have accomplished",
        "positive things about your day",
        "people that helped you today",
        "people that are there for you",
        "fun activities you can do right now",
        "things you are looking forward to",
        "future plans that you are excited for",
        "pets you would like to own",
        "places you would want to visit",
        "foods you like to eat",
        "foods you are curious to try"
    };
    public void program(int _BCtimer)
    {
        Console.WriteLine("This activity will help you when you are feeling down by asking you to list some positive ascpets of your life.");
        mind.spinner(8);
        _BCbool = true;
        Timer timer = new Timer(stoploop, null, _BCtimer * 1000, Timeout.Infinite);
        int index = 0;
        List<int> used_prompts = new List<int>();
        mind.loading();
        while (_BCbool)
        {
            bool bool_var = false;
            do
            {
                index = random.Next(0, prompts.Count());
                if (used_prompts.Contains(index) )
                {
                    bool_var = true; 
                }
                else
                {
                    bool_var = false;
                    used_prompts.Add(index);
                    if (used_prompts.Count() == prompts.Count())
                    {
                        _BCbool = false;
                    }
                }
            }while (bool_var);


            int randomNumber = random.Next(5, 10);

            Console.WriteLine($"List {randomNumber} " + prompts[index] + ".");
            Console.WriteLine("When you finish press enter to continue");
            Console.ReadLine();
            
        }
        
    }
    
    void stoploop(object state)
        {
            _BCbool = false;
        }
   }
