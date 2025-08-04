using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        Console.Write("Nhập phần tử cần xóa (X): ");
        int x = int.Parse(Console.ReadLine());
        Delete(array, x);
    }

    static void Delete(int[] a, int x)
    {
        int index = -1;

       
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == x)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            Console.WriteLine("Phần tử không tồn tại trong mảng.");
            return;
        }

        // Dồn phần tử phía sau lên
        for (int i = index; i < a.Length - 1; i++)
        {
            a[i] = a[i + 1];
        }

       
        Console.WriteLine("Mảng sau khi xoá phần tử:");
        for (int i = 0; i < a.Length - 1; i++)
        {
            Console.Write(a[i] + " ");
        }
    }
}
