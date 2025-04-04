abstract class Goal
{
    public string Name { get; protected set; }
    public string Description { get; protected set; }
    public int Points { get; protected set; }
    public abstract bool IsComplete { get; }
    public abstract void RecordEvent(ref int score);
    public abstract string GetStatus();
    public abstract string Serialize();
    public static Goal Deserialize(string line)
    {
        string[] parts = line.Split("|");
        string type = parts[0];
        
        switch (type)
        {
            case "SimpleGoal": 
                return new SimpleGoal(parts);
                
            case "EternalGoal": 
                return new EternalGoal(parts);
                
            case "ChecklistGoal": 
                return new ChecklistGoal(parts);
                
            default: 
                return null;
        }
    }
}