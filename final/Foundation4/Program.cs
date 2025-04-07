using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>
        {
            new Run(10, 60, "08/12/2036"),
            new Swim(25, 120, "02/14/2174"),
            new Cycle(55, 60, "08/21/2015")
        };
        
        Console.Clear();
        foreach(Activity _activity in _activities)
        {
            Console.WriteLine(_activity.Summary());
        }
    }
}