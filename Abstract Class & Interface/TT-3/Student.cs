

public class Student
{
    public string name { set; get; }
    public int Age { set; get; }

    public string Grade { set; get; }

    public Student(string name, int Age, string Grade)
    {
        this.name = name;
        this.Age = Age;
        this.Grade = Grade;
    }

    public void DisPlayInfor()
    {
        Console.WriteLine($"{name}");
    }
}