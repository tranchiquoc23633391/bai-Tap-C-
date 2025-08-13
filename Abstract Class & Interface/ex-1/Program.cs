

public interface Edible
{
   string howToEat();
}

public abstract class Animal
{
    public Animal() { }

    public abstract string makeSound();
}

public abstract class Fruit : Edible
{
    public abstract string howToEat();
}

public class Chicken : Animal, Edible
{
    public string howToEat()
    {
        return "chick ăn bằng mồm";
    }

    public override string makeSound()
    {
        return "chicken kêu cok cok cok";
    }
}

public class Tiger : Animal
{
    public override string makeSound()
    {
        return "Tiger kêu arhhhhhh";
    }
}

public class Orange : Fruit
{
    public override string howToEat()
    {
        return "Orange could be juiced";

    }
}

public class Apple : Fruit
{
    public override string howToEat()
    {
        return "Apple could be slided";

    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Animal[] animal = new Animal[2];
        animal[0] = new Tiger();
        animal[1] = new Chicken();

        foreach (Animal animals in animal)
        {
            Console.WriteLine(animals.makeSound());

            if (animals is Chicken)
            {
                Edible edible = (Chicken)animals;
                Console.WriteLine(edible.howToEat());
            }
        }

        Apple apple = new Apple();
        Console.WriteLine(apple.howToEat());

        Orange or = new Orange();
        Console.WriteLine(or.howToEat());
    }
}
