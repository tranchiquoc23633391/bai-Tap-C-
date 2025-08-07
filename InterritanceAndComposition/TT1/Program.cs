public class Program
{
    public static void Main(string[] args)
    {

    }
}


public class circle
{
    double radius;

    public circle(double r)
    {
        this.radius = r;
    }

    public virtual void area()
    {
        Console.WriteLine("ahihi");
    }
}


public class cyliner : circle
{
    double height;

    public cyliner(double r, double h) : base(r)
    {
        height = h;

    }

    public override void area()
    {
        Console.WriteLine("meomeo");
    }
}

public class cone : circle
{
    public cone(double r) : base(r)
    {
    }
}