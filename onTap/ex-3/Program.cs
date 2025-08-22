

public class Program
{
    public static void Main(string[] args)
    {
        var Config = Singleton<Config>.Instance;

        Config.AppName = "MyApplication";
        var logger = Singleton<Logger>.Instance;
        logger.Log("Application started");
    }
}