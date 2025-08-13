
public class Wall : Decoder
{
    public string color;
    public double height;
    public double width;

    public Wall(string input, string color, double height, double width) : base(input)
    {
        this.color = color;
        this.height = height;
        this.width = width;
    }

    public void DisplayWallInfo()
    {
        Console.WriteLine($"Wall color: {color}, Height: {height}m, Width: {width}m");
    }

    public override void DisplayDecoded()
    {
        base.DisplayDecoded();
        Console.WriteLine($"Wall color: {color}, Height: {height}m, Width: {width}m");
    }

    public override string Decode()
    {
        // Placeholder for decoding logic specific to Wall
        return base.Decode(); // For now, just return the input as is
    }
}