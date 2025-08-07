public abstract class Shape
{
    string name;
    int id;

    protected Shape(string name)
    {
        this.name = name;
    }

    protected Shape(string name, int id)
    {
        this.name = name;
        this.id = id;
    }
}

public class Circle : Shape
{
    double radius;

    public Circle(string name) : base(name) { }

    public Circle(string name, int id) : base(name, id) { }
}

public class Program
{
    public static void Main(string[] args)
    {
        Circle c = new Circle("Circle A", 1);
        Console.WriteLine("Circle created.");
    }
}
