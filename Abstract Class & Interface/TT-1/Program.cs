
public class Vehice
{
    public string Name { set; get; }
    public int speed { set; get; }

    public Vehice(string Name, int speed)
    {
        this.Name = Name;
        this.speed = speed;
    }

    public void displayInfor()
    {
        Console.WriteLine($"vehice name:{Name}, speed: {speed}");
    }

    public virtual void startEngine()
    {
        Console.WriteLine($"name:{Name} engine stared");
    }


}


public class car : Vehice
{
    public int NumberOfDoors { set; get; }
    public car(string Name, int speed, int NumberOfDoors) : base(Name, speed)
    {
        this.NumberOfDoors = NumberOfDoors;
    }

    public void DisplaycarInfor()
    {
        displayInfor();
        Console.WriteLine($"{NumberOfDoors} ");
    }

    public override void startEngine()
    {
        Console.WriteLine($"{Name} car en ,,,");
    }
}
public class carRed : car
{
    string color;
    public carRed(string Name, int speed, int NumberOfDoors, string color) : base(Name, speed, NumberOfDoors)
    {
        this.color = color;
    }

    public void DisplaycarInfor()
    {
        displayInfor();
        Console.WriteLine($"color: {color} ");
    }

    public override void startEngine()
    {
        Console.WriteLine($"{Name} car en ,,,");
    }


}

public class Program
{
    public static void Main(string[] args)
    {
        Vehice myv = new Vehice("abc", 80);
        myv.displayInfor();
        myv.startEngine();

        car c = new car("xyz", 10, 2);
        c.DisplaycarInfor();

    }
}