public abstract class Animal
{
    protected string weight { get; set; }
    protected string heigt { get; set; }

    public Animal(string weight, string heigt)
    {
        this.weight = weight;
        this.heigt = heigt;
    }

    public abstract void PrintfInfo();
}

class cat : Animal
{
    private string name { get; set; }

    public cat(string name, string weight, string heigt) : base(weight, heigt)
    {
        this.name = name;
    }

    public override void PrintfInfo()
    {
        Console.WriteLine("Weight {0} :" + '\n' + "Height: {1}" + '\n' + "Name: {2}", this.weight, this.heigt, this.name);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        cat cat1 = new cat("kitty", "20kg", "1.5");

        cat1.PrintfInfo();
    }
}