
public class Student
{
    private int rollno;
    private string name;

    private static string college = "abc";

    public Student(int rollno, string name)
    {
        this.rollno = rollno;
        this.name = name;
    }

    public static void change()
    {
        college = "xyz";
    }

    public void Display()
    {
        Console.WriteLine(rollno + " " + name + " " + college);
    }

}


public class Program
{
    public static void Main(string[] args)
    {
            Student.change();//calling change method
                             //creating objects
            Student s1 = new Student(111, "Hoang");
            Student s2 = new Student(222, "Khanh");
            Student s3 = new Student(333, "Nam");
            //calling display method
            s1.Display();
            s2.Display();
            s3.Display();
    }
}