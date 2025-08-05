
public class student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double MathScore { get; set; }

    public student(string name, int age, double englishScore)
    {
        Name = name;
        Age = age;
        MathScore = englishScore;
    }

    public void DisplayInfor()
    {
        Console.WriteLine($"student: {Name}, age:{Age}");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        student student1 = new student("ali", 20, 20);
        student student2 = new student("qani", 20, 20);
        // Console.WriteLine($"student: {student1.Name}, age:{student1.Age}");
        student1.DisplayInfor();
    }
}