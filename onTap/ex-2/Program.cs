



public abstract class Animal
{
    public abstract void Speak();
}

public class Dog : Animal
{

    public override void Speak()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Meow!");
    }
}


public abstract class AnimalFactory
{
    public abstract Animal CreateAnimal();
}

public class DogFactory : AnimalFactory
{
    public override Animal CreateAnimal()
    {
        return new Dog();
    }
}

public class CatFactory : AnimalFactory
{
    public override Animal CreateAnimal()
    {
        return new Cat();
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        AnimalFactory dogFactory = new DogFactory();
        Animal dog = dogFactory.CreateAnimal();
        dog.Speak(); // Output: Woof!

        AnimalFactory catFactory = new CatFactory();
        Animal cat = catFactory.CreateAnimal();
        cat.Speak(); // Output: Meow!   

        
    }
}
