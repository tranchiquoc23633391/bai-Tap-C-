

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    override public string ToString()
    {
        return $"Name: {Name} - Price: {Price}";
    }
}