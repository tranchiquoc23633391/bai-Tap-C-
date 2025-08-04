public class Program
{
    public static void Main(string[] args)
    {
        string a = "xin2chao";
        int dem = countLetter(a);
        Console.WriteLine("chuoi co " + dem + " chu");
    }

    static int countLetter(string a)
    {
        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if ((a[i] >= 'a' && a[i] <= 'z') || (a[i] >= 'A' && a[i] <= 'Z'))
            {
                count++;
            }
        }

        return count;
    }
}