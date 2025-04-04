class SimpleGoal : Goal
{
    private bool completed;

    public override bool IsComplete => completed;

    public SimpleGoal(string name, string desc, int points)
    {
        Name = name;
        Description = desc;
        Points = points;
        completed = false;
    }

    public SimpleGoal(string[] data)
    {
        Name = data[1];
        Description = data[2];
        Points = int.Parse(data[3]);
        completed = bool.Parse(data[4]);
    }

    public override void RecordEvent(ref int score)
    {
        if (!completed)
        {
            completed = true;
            score += Points;
        }
    }

    public override string GetStatus() => $"[{(completed ? "X" : " ")}] {Name}";

    public override string Serialize() => $"SimpleGoal|{Name}|{Description}|{Points}|{completed}";
}