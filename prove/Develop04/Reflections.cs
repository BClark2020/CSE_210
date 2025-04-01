    public class Reflection : Mindfullness_app
   {

    public Mindfullness_app mind = new Mindfullness_app();
    
    private Random random = new Random();
    private int randomNumber = 0;

    private List<string> prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> follow_ups = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public void program(int _BCtimer)
    {
        Console.Clear();
        Console.WriteLine("This activity will help you recognize the strength and power you have by reflecting on moments you showed these atributes and help you learn how to use them.");
        mind.spinner(8);
        Console.Clear();
        Console.WriteLine(prompts[randomNumber = random.Next(0, prompts.Count())]);
        mind.spinner(7);
    
        
        
        bool _BCbool = true;
        Timer timer = new Timer(stoploop, null, _BCtimer * 1000, Timeout.Infinite);
        int index = 0;
        while (_BCbool)
        {
            try
            {
                Console.WriteLine(follow_ups[index]);
                mind.spinner(5);
                index += 1;
           }
            catch (ArgumentOutOfRangeException)
            {
                _BCbool = false;
            }
        
        }
        void stoploop(object state)
        {
            _BCbool = false;
        }
    }

}