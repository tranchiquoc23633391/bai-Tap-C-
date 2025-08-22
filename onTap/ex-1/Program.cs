

public class Program
{
    public static void Main(string[] args)
    {

        Repository<Product> repository = new Repository<Product>();

        repository.AddFunc(new Product { Name = "Laptop", Price = 999.99 });
        repository.AddFunc(new Product { Name = "Smartphone", Price = 499.99 });
        repository.AddFunc(new Product { Name = "Tablet", Price = 299.99 });

        foreach (var item in repository.GetAll())
        {
            Console.WriteLine(item);
        }
    }
}