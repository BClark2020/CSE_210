 
   public class Affirmations : Mindfullness_app
   {
    Mindfullness_app mind = new Mindfullness_app();
    Random random = new Random();
    private int randomNumber = 0;
    private List<string> affirmations = new List<string>()
    {
        "I am happy.",
        "I am able.",
        "I am strong.",
        "I am worth it.",
        "I am loved.",
        "I have unlimited potential.",
        "I am free to make my own decisions.",
        "I love myself and all my flaws.",
        "I am good enough.",
        "I am in control of myself and my actions.",
        "I deserve to do what makes me happy.",
        "I am fearless."

    };
    public void program(int _BCtimer)
    {
        Console.Clear();
        Console.WriteLine("This activity will help you achieve confidence in yourself through positive affirmations that are designed to boost self esteem.");
        mind.spinner(8);
        Console.Clear();
       Console.WriteLine("Repeat aloud the phrases you see on your screen.");
        mind.spinner(7);
    
      
        bool _BCbool = true;
        Timer timer = new Timer(stoploop, null, _BCtimer * 1000, Timeout.Infinite);
        int index = 0;
        while (_BCbool)
        {
            List<int> used_indexes = new List<int>(); 
            bool bool_var = false;
            do
            {
                randomNumber = random.Next(0, affirmations.Count());
                bool found = used_indexes.Contains(randomNumber);
                if (found)
                {
                    bool_var = true;
                }
                else
                {
                    bool_var = false;
                    used_indexes.Add(randomNumber);
                }
                
            }while(bool_var);
            
            try
            {
                Console.WriteLine(affirmations[randomNumber]);
                mind.spinner(4);
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

