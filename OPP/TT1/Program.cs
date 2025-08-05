using System.Reflection.Metadata;

public class shap
{
    public string Name { get; set; }
    public double Area { get; set; }

    public shap(string Name, double Area)
    {
        this.Name = Name;
        this.Area = Area;
    }
}


public class circle : shap
{
    public circle(double Area) : base("circle", Area) { }
}

public class square : shap
{
    public square(double Area) : base("square", Area) { }
}

public class Program
{
    public static void Main(string[] args)
    {
        shap shap1 = new shap("c", 7);
        shap shap2 = new shap("c", 7);
        circle cir = new circle(78.5);

        shap shap3 = new circle(785);
    }
}