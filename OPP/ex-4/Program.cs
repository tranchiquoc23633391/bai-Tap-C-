

public class Fan
{
    public const int Slow = 1;
    public const int Medium = 2;
    public const int Fast = 3;

    ///
    private int Speed { set; get; }
    private bool on { set; get; }
    private double radius { set; get; } = 5;
    private string color { set; get; } = "blue";

    ///

    public Fan() { }

    public Fan(int speed, bool on, double radius, string color)
    {
        this.Speed = speed;
        this.on = on;
        this.radius = radius;
        this.color = color;
    }

    //
    public string toString()
    {
        if (this.on)
            return $"Speed: {this.Speed}, Color: {this.color}, Radius: {this.radius} — Fan is ON";
        else
            return $"Color: {this.color}, Radius: {this.radius} — Fan is OFF";
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Fan fan1 = new Fan(Fan.Fast, true, 10, "yellow");
        Fan fan2 = new Fan(Fan.Medium, false, 5, "blue");

        Console.WriteLine(fan1.toString());
        Console.WriteLine(fan2.toString());

    }
}