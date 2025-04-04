using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static List<Goal> goal = new List<Goal>();
    static int score = 0;
    

    static void Main()
    {

        LoadData();
        while (true)
        {
            Console.Clear();
            ShowScoreAndLevel();
            
            Console.WriteLine("1.) Make Goal\n2.) List Goals\n3.) Record Event\n4.) Save\n5.) Load\n6.) Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();
            Console.WriteLine("\n");
            
            switch (option)
            {
                case "1": 
                    CreateGoal(); 
                    break;
                    
                case "2": 
                    ListGoals(0); 
                    break;
                    
                case "3": 
                    RecordEvent(); 
                    break;
                    
                case "4": 
                    SaveData();
                     break;
                     
                case "5": 
                    LoadData(); 
                    break;
                    
                case "6": 
                    return;
            }
        }
    }

    static void ShowScoreAndLevel()
    {
        int level = score / 1000 + 1;
        Console.WriteLine($"Score: {score} | Level: {level}\n");
    }

    static void CreateGoal()
    {
        bool var = true;
        string choice = " ";
        int points = 0;
        
        while(var)
        {
            Console.WriteLine("Select goal type:\n1.) Simple Goal\n2.) Eternal Goal\n3.) Checklist Goal");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();
            if (choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("PLease enter an integer between 1 and 3 to make you selection.");
                var = true;
            }
            else
            {
                var  = false;
            }
        }
        
        
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        
        var  = true;
        while(var)
        {
            try
            {
                Console.Write("Enter points: ");
                points = int.Parse(Console.ReadLine());
                var = false;
            }
            catch (FormatException) 
            {
                Console.WriteLine("ERROR: Please enter an integer value.");
                var = true;
            } 
        }

        if (choice == "1")
        { 
            goal.Add(new SimpleGoal(name, desc, points));
        }
        else if (choice == "2")
        {
            goal.Add(new EternalGoal(name, desc, points));
                
        }
        else if (choice == "3")
        {
            int bonus = 0;
            int target = 0;
        
            var  = true;
            while(var)
            {
                try
                {
                    Console.Write("Enter target count: ");
                    target = int.Parse(Console.ReadLine());
                    var = false;
                }
                catch (FormatException) 
                {
                    Console.WriteLine("ERROR: Please enter an integer value.");
                    var = true;
                } 
            }
            
            
            
            var  = true;
            while(var)
            {
                try
                {
                    Console.Write("Enter bonus points: ");
                    bonus = int.Parse(Console.ReadLine());
                    var = false;
                }
                catch (FormatException) 
                {
                    Console.WriteLine("ERROR: Please enter an integer value.");
                    var = true;
                } 
            }
            
                
            goal.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }     
    }


    static void ListGoals(int wait)
    {
        Console.WriteLine("\nYour Goals:");
        
        for (int i = 0; i < goal.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goal[i].GetStatus()}");
        }
        
        if (wait == 0)  
        {
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        } 
    }

    static void RecordEvent()
    {
        ListGoals(1);
        int index = 0;
        bool var = true;
        while(var)
        {
            try
            {
                Console.Write("Enter goal number to record: ");
                index = int.Parse(Console.ReadLine()) - 1;
                var  = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: Please enter an integer value.");
                var = true;   
            }
        }
        
        if (index >= 0 && index < goal.Count)
        {
            goal[index].RecordEvent(ref score);
        }  
    }

    static void SaveData()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            
            writer.WriteLine(score);
            
            foreach (var g in goal)
            {
               writer.WriteLine(g.Serialize()); 
            }          
        }
        
    }

    static void LoadData()
    {
        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            score = int.Parse(lines[0]);
            goal.Clear();
            
            for (int i = 1; i < lines.Length; i++)
            {
                goal.Add(Goal.Deserialize(lines[i])); 
            }
                
        }
    }
}
