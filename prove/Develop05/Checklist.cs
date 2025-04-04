class ChecklistGoal : Goal
{
    private int targetCount;
    private int completedCount;
    private int bonus;

    public override bool IsComplete => completedCount >= targetCount;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus)
    {
        Name = name;
        Description = desc;
        Points = points;
        targetCount = target;
        this.bonus = bonus;
        completedCount = 0;
    }

    public ChecklistGoal(string[] data)
    {
        Name = data[1];
        Description = data[2];
        Points = int.Parse(data[3]);
        targetCount = int.Parse(data[4]);
        completedCount = int.Parse(data[5]);
        bonus = int.Parse(data[6]);
    }

    public override void RecordEvent(ref int score)
    {
        if (completedCount < targetCount)
        {
            completedCount++;
            score += Points;
            if (completedCount == targetCount)
            {
                score += bonus;
            }   
        }
    }

    public override string GetStatus()
    {
        string done = IsComplete ? "X" : " ";
        
        return $"[{done}] {Name} (Completed {completedCount}/{targetCount})";
    }

    public override string Serialize() => $"ChecklistGoal|{Name}|{Description}|{Points}|{targetCount}|{completedCount}|{bonus}";
}