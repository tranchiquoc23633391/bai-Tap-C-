
public class shape
{
    public string color { set; get; } = "green";
    public Boolean filled { set; get; } = true;

    public shape() { }

    public shape(string color, Boolean filled)
    {
        this.filled = filled;
        this.color = color;
    }

    public virtual string toString()
    {
        return "A Shape with color of " + color + " and " + (filled ? "filled" : "not filled");
    }

}


public class circle : shape
{
    private double radius { set; get; } = 1.0;

    public circle(double radius, string color, Boolean filled) : base(color, filled)
    {
        this.radius = radius;

    }

    public circle() { }

    public circle(double radius) { }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }

    public virtual string toString()
    {
        return "A Circle with radius = " + radius + "which is a subclass of " + base.toString();
    }

}

public class Rectangle : shape
{
    protected double width { set; get; } = 1.0;
    protected double length { set; get; } = 1.0;

    public Rectangle(double width, double length)
    {
        this.width = width;
        this.length = length;
    }

    public Rectangle(double width, double length, string color, Boolean filled) : base(color, filled)
    {
        this.width = width;
        this.length = length;
    }

    public virtual double getWidth() => width;
    public virtual void setWidth(double width) => this.width = width;

    public virtual double getLength() => length;
    public virtual void setLength(double length) => this.length = length;

    public double GetArea()
    {
        return width * length;
    }

    public double GetPerimeter()
    {
        return 2 * (width + length);
    }

    public override string ToString()
    {
        return $"A Rectangle with width={width} and length={length}, which is a subclass of {base.ToString()}";
    }

}


public class Square : Rectangle
{
    public Square() : base(1.0, 1.0) { }

    public Square(double side) : base(side, side) { }
    public Square(double side, string color, bool filled) : base(side, side, color, filled) { }

    public double GetSide()
    {
        return width;
    }

    public void SetSide(double side)
    {
        width = side;
        length = side;
    }

    public virtual void SetWidth(double side)
    {
        width = side;
        length = side;
    }

    public virtual void SetLength(double side)
    {
        width = side;
        length = side;
    }

    public override string ToString()
    {
        return $"A Square with side={width}, which is a subclass of {base.ToString()}";
    }

}





public class Program
{
    public static void Main(string[] args)
    {
        Square square = new Square();
        Console.WriteLine(square);

        square = new Square(2.3);
        Console.WriteLine(square);

        square = new Square(5.8, "yellow", true);

        Console.WriteLine(square);

    }
}