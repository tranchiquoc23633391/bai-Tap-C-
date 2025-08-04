public class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 6, 5, 4, 3, 2, 1 };
        int index = minArray(array);
        Console.WriteLine("gia tri nho nhat la :" + index);
    }

    static int minArray(int[] a)  // thêm từ khóa static ở đây
    {
        int min = a[0];
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < min)
            {
                min = a[i];
            }
        }
        return min;
    }
}
