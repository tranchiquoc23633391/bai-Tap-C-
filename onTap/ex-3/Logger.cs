

public class Logger
{
    public Logger() { }

    public void Log(string message)
    {
        // Implement logging logic here
        Console.WriteLine($"[{DateTime.Now}] {message}");
    }
}