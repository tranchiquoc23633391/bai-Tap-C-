public class Program
{
    public static void Main(string[] args)
    {
        List<char> characters = new List<char>();
        characters.InsertRange(0, new char[] { 'a', 'b', 'c', 'd', 'e', 'f' });

        try
        {
            List<char> innerCharacters = new List<char>();
            innerCharacters.InsertRange(0, new char[] { 'g', 'h', 'i', 'j', 'k', 'l' });
            char s = innerCharacters[5];

        }
        catch (IndexOutOfRangeException e)
        {
            System.Console.WriteLine(e);
        }
    }
}