public class Program
{
    public static void Main(string[] args)
    {
        double fah, cels;
        int choice;

        do
        {
            Console.WriteLine("Menu.");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    cels = Double.Parse(Console.ReadLine());
                    double F = CelsiusToFahrenheit(cels);
                    Console.WriteLine(+F);

                    break;
                case 2:
                    fah = Double.Parse(Console.ReadLine());
                    double C = CelsiusToFahrenheit(fah);
                    Console.WriteLine(+C);
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        } while (choice != 0);

    }


    // C to F
    static double CelsiusToFahrenheit(double cel)
    {
        double fahrenheit = (9.0 / 5) * cel + 32;
        return fahrenheit;
    }

    //F to C

    public static double FahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (5.0 / 9) * (fahrenheit - 32);
        return celsius;
    }

}