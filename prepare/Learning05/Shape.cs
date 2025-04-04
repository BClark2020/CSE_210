// Base class
public abstract class Shape
{
    protected string Color { get; set; }

    public Shape(string color)
    {
        Color = color;
    }

    public string GetColor()
    {
        return Color;
    }

    public abstract double GetArea();
}

