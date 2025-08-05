
public class Rectangle
{
    public double width { get; set; }
    public double height { get; set; }

    public Rectangle() { }

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    // phuong thuc 

    public double getArea()
    {
        return this.width * this.height;
    }

    public double getPerimeter()
    {
        return (this.width + this.height) * 2;
    }

    public string disPlay()
    {
        return "Rectangle{" + "with =" + width + ",height = " + height + "}";
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the width:");
        double width = Double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height:");
        double height = Double.Parse(Console.ReadLine());

        Rectangle a1 = new Rectangle(width, height);

        Console.WriteLine("Your Rectangle \n" + a1.disPlay());
        Console.WriteLine("Perimeter of the Rectangle: " + a1.getArea());
        Console.WriteLine("Area of the Rectangle: " + a1.getPerimeter());
    }
}