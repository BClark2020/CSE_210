 public class Meditation : Mindfullness_app
   {
    
    Mindfullness_app mind = new Mindfullness_app();
    Random random = new Random();  
    public void program(int _BCtimer)
    {
        Console.Clear();
        Console.WriteLine("This activity will help you achieve a calm mental state through a series of breathing excersizes.");
        mind.spinner(8);
        Console.Clear();
        Console.WriteLine("We will start in");
        Console.WriteLine("3");
        Thread.Sleep(1000);
        Console.WriteLine("2");
        Thread.Sleep(1000);
        Console.WriteLine("1");
        Thread.Sleep(1000);
        
        bool _BCbool = true;
        Timer timer = new Timer(stoploop, null, _BCtimer * 1000, Timeout.Infinite);
        
        while (_BCbool)
        {
            Console.Clear();
            Console.WriteLine("Breathe in");
            hold(4);
            Console.Clear();
            Console.WriteLine("Hold");
            hold(4);
            Console.Clear();
            Console.WriteLine("Breathe out");
            hold(4);
            Console.Clear();
            Console.WriteLine("Hold");
            hold(4);
            
        }
        void stoploop(object state)
        {
            _BCbool = false;
        }
    }

    private void hold(int repetition)
    {
        Console.WriteLine("");
        int counter = 0;
        for (int i = 0; i < repetition; i++ )
        {
            counter += 1;
            Console.Write($"{counter},");
            Thread.Sleep(1000);

        }
    }
}
