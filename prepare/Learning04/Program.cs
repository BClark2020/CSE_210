using System;
using System.Runtime.InteropServices;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        List<string> _assignments = new List<string>();
        string _name;
        Console.Write("Enter your name: ");
        _name = Console.ReadLine();
        bool loop = true;
        while(loop)
        {
            
            string _topic = " ";
            string _problem = " ";
            string _textbook =  " ";
            string _title = " ";
            Console.Clear();
            Console.WriteLine("Enter 'leave' to quit program.");
            Console.Write("1.) Math Assignment\n 2.) Writing assignemnt");
            string option = Console.ReadLine();
            
            switch(option)
            {
                case "1":
                Console.Clear();
                Console.Write("Enter the topic: ");
                _topic = Console.ReadLine();
                Console.Write("Enter reading chapter: ");
                _textbook = Console.ReadLine();
                Console.Write("Enter problem list: ");
                _problem = Console.ReadLine();
                break;
                
                case "2":
                Console.Clear();
                Console.Write("Enter the topic: ");
                _topic = Console.ReadLine();
                Console.Write("Enter the title: ");
                _title = Console.ReadLine();
                break;
                
                case "leave":
                Console.WriteLine("Thank you for using my program (~^-^)~");
                Console.WriteLine("Here is the list of your assignments: ");
                p.DisplayAssignemnts(_assignments);
                break;
                
                default:
                Console.Clear();
                Console.WriteLine("Please enter either 1 or 2 or enter the key word 'leave'.");
                break;
            }
            
            if(option == "1")
            {
                Assignment assign = new Assignment(_name, _topic);
                Math math = new Math(_name, _topic, _textbook, _problem);
                string homework = assign.GetSummary() + "\n" + math.GetHomeworkList();
                _assignments.Add(homework);
            } else if (option == "2")
            {
                Assignment assign = new Assignment(_name, _topic);
                Writing write = new Writing(_name, _topic, _title);
                string homework = assign.GetSummary() + "\n" + write.GetWritingInformation();
                _assignments.Add(homework);
            }
          
        } 
        
    }
    
    
    
    private void DisplayAssignemnts(List<string> assignments)
    {
        int length = assignments.Count();
        for(int i = 0; i < length; i++)
        {
           Console.WriteLine(assignments[i]);
           Console.WriteLine("\n\n");
        }
    }
}