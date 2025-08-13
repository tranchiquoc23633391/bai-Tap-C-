public class Decoder
{
    // Trường để lưu trữ dữ liệu đầu vào.
    protected string _input;

    // Constructor để khởi tạo đối tượng Decoder với dữ liệu đầu vào.
    public Decoder(string input)
    {
        _input = input;
    }

    // Phương thức ảo (virtual) cho phép các lớp con ghi đè (override).
    public virtual void DisplayDecoded()
    {
        Console.WriteLine($"Decoding input: {_input}");
    }

    // Phương thức ảo (virtual) để giải mã dữ liệu đầu vào.
    public virtual string Decode()
    {
        // Logic giải mã mặc định, ví dụ: trả về chính dữ liệu đầu vào.
        return _input;
    }
}