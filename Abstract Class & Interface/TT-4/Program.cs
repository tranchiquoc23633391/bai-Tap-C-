


using System.Data.Common;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

public class Shape
{
    private string color = "green";
    private bool filled = true;
    public Shape() { }

    public Shape(string color, bool filled)
    {
        this.color = color;
        this.filled = filled;
    }

    public string GetColor()
    {
        return this.color;
    }

    public bool IsFilled()
    {
        return this.filled;
    }

    public void setFilled(bool filled)
    {
        this.filled = filled;
    }

    public void setColor(String color)
    {
        this.color = color;
    }

    public override string ToString()
    {
        return "Getcolor" + this.color + this.filled;
    }
}


public class Circle : Shape
{
    private double radius;

    public Circle() { }

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public Circle(double radius, string color, bool filled) : base(color, filled)
    {
        this.radius = radius;
    }

    public double getRadius()
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

    public double GetPerimemter()
    {
        return 2 * Math.PI * radius;
    }
}


public class Rectangle : Shape
{
    public double height;
    public double width;

    public Rectangle() { }

    public Rectangle(double height, double width) : base() // gọi constructor mặc định của Shape
    {
        this.height = height;
        this.width = width;
    }

    public Rectangle(double height, double width, string color, bool IsFilled) : base(color, IsFilled)
    {
        this.height = height;
        this.width = width;
    }

    public double GetHeigth()
    {
        return height;
    }

    public double GetWidth()
    {
        return width;
    }

    public virtual void setHeight(double height)
    {
        this.height = height;
    }

    public virtual void setWidth(double width)
    {
        this.width = width;
    }

    public double GetArea()
    {
        return width * height;
    }

    public double GetPerimemter()
    {
        return 2 * (width * height);
    }

}


public class Square : Rectangle
{
    public Square() { }

    public Square(double side) : base(side, side) { }

    public Square(double side, string color, bool filled) : base(side, side, color, filled) { }

    public void setSize(double side)
    {
        base.setWidth(side);
        base.setHeight(side);

    }


}


public class ComperableCircle : Circle, IComparable<ComperableCircle>
{

    public ComperableCircle() { }
    public ComperableCircle(double radius) : base(radius) { }

    public ComperableCircle(double radius, string color, bool IsFilled): base(radius){}

    public int CompareTo(ComperableCircle? other)
    {
        if (getRadius() > other.getRadius())
        {
            return 1;

        }
        else if (getRadius() > other.getRadius())
        {
            return -1;
        }
        else
            return 0;
    }
}

public class Program
{
    public static void Main(string[] args)
    {

    }
}