

public class circle
{
    public double radius { set; get; } = 1.0;
    public string color { set; get; } = "green";
    public bool filled { set; get; } = true;

    public circle() { }
    public circle(double radius, string color, bool filled)
    {
        this.radius = radius;
        this.color = color;
        this.filled = filled;
    }

    public double GetRadius()
    {
        return radius;
    }

    public void setRadius(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }

    public override string ToString()
    {
        return "A Circle with radius = " + radius + ", which is a subclass of " + base.ToString();
    }

}


public class Cylinder : circle
{
    double height = 1.0;

    public Cylinder() { }

    public Cylinder(double height)
    {
        this.height = height;
    }
    public Cylinder(double radius, double height, string color, bool filled) : base(radius, color, filled)
    {
        this.height = height;
    }

    public double getHeight()
    {
        return height;
    }

    public void setHeight(double height)
    {
        this.height = height;
    }

    public double GetVolume()
    {
        return Math.PI * Math.Pow(GetRadius(), 2) * height;
    }

    public double GetSurfaceArea()
    {
        double r = GetRadius();
        return 2 * Math.PI * r * height + 2 * Math.PI * r * r;
    }

    public override string ToString()
    {
        return $"A Cylinder with radius = {GetRadius()} and height = {height}, which is a subclass of {base.ToString()}";
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        circle c1 = new circle(20, "red", true);
        Console.WriteLine(c1);

        Cylinder c2 = new Cylinder(20);
        Console.WriteLine(c2);

        Cylinder c3 = new Cylinder(10, 20, "blue", false);
        Console.WriteLine(c3);

        Console.WriteLine("Volume of c3: " + c3.GetVolume());
        Console.WriteLine("Surface area of c3: " + c3.GetSurfaceArea());


    }
}