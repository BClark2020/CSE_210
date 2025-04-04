class EternalGoal : Goal
{
    public override bool IsComplete => false;

    public EternalGoal(string name, string desc, int points)
    {
        Name = name;
        Description = desc;
        Points = points;
    }

    public EternalGoal(string[] data)
    {
        Name = data[1];
        Description = data[2];
        Points = int.Parse(data[3]);
    }

    public override void RecordEvent(ref int score)
    {
        score += Points;
    }

    public override string GetStatus() => $"[∞] {Name}";

    public override string Serialize() => $"EternalGoal|{Name}|{Description}|{Points}";
}