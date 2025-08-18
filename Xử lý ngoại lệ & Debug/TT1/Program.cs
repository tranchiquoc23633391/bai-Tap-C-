using System.Buffers;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            // int a = Convert.ToInt32(Console.ReadLine());
            // int b = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"Thuong La{a / b}");
            int x = int.Parse("abc");
        }
        catch (FormatException e)
        {
            Console.WriteLine($"ban da nhap so 0{e.Message}");

        }
        ;
        try
        {
            int[] arr = new int[12];
            Console.WriteLine(arr[13]);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"ngoai khoang{e.Message}");
        }
        finally
        {
            Console.WriteLine("ket thuc");
        }

    }
}