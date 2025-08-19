using System;

class Program
{
    static void Main(string[] args)
    {
        // Bước 2: Khai báo biến tỉ giá
        double rate = 23000;

        // Bước 3: Nhập giá trị USD từ người dùng
        Console.Write("Enter the amount in USD: ");
        double usd = double.Parse(Console.ReadLine());

        // Bước 4: Tính và hiển thị giá trị VND
        double vnd = usd * rate;
        Console.WriteLine("Equivalent amount in VND: " + vnd);
    }
}
