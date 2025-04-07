using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address _addrs1 = new Address("123 Elmer LN", "Salt Lake City", "Utah", "USA");
        Address _addrs2 = new Address("1456 Country Home Lane", "great Falls", "Montana", "USA");
        Address _addrs3 = new Address("256 Kennedy Drive", "Enteprise", "Alabama", "USA");
        
        List<Event> _events =  new List<Event>
        {
            new Lecture("Mathematics in Practice", "Learn about the amazing world math can be used to predict or even tame.", 
            "04/15/2027", _addrs1, "Professor Alvarez", 250),
            new Reception("Recpetion of Mr. & Mrs. Pinochet", "Join us for a beautiful recption of the newly wedded Pinochets. Colors to be worn are black and white",
            "04/09/2025", _addrs2, "Maddy.Furgus23@gmail.com"),
            new Gathering("McGee Family Reunion", "A wonderful outdoor BBQ for our annual McGee family get-together.",
            "07/14/2068", _addrs3, "Sunny, 98°F")
        };
        
        
        foreach (Event _event in _events)
        {
            Console.Clear();
            Console.WriteLine(_event.DisplayFullDetails());
            Console.WriteLine("\n");
            Console.WriteLine(_event.DisplayStandardDetails());
            Console.WriteLine("\n");
            Console.WriteLine(_event.DisplayShortDeescription());
            Console.WriteLine("\n"); 
            string _wait = Console.ReadLine();
            
        };
    }
}