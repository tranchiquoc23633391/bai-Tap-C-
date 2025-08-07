


public class Point2D
{
    float x = 0.0f;
    float y = 0.0f;

    public Point2D() { }
    public Point2D(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public float getX()
    {
        return x;
    }

    public void setX(float x)
    {
        this.x = x;
    }

    public float getY()
    {
        return y;
    }

    public void setY(float y)
    {
        this.y = y;
    }

    public float[] getXY()
    {
        return new float[] { x, y };
    }

    public void setXY(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return $"({x}, {y})";
    }

}


public class Point3D : Point2D
{
    float z = 0.0f;

    public Point3D(float z) : base()
    {
        this.z = z;
    }

    public Point3D(float x, float y, float z) : base(x, y)
    {
        this.z = z;
    }

    public float getZ()
    {
        return z;
    }

    public void setZ(float z)
    {
        this.z = z;
    }


    public float[] getXYZ()
    {
        return new float[] { getX(), getY(), z };
    }

    public void setZ(float x, float y, float z)
    {
        setX(x);
        setY(y);
        this.z = z;
    }


    public override string ToString()
    {
        return $"{getX()}, {getY()} , {z}";
    }


}

public class Program
{
    public static void Main(string[] args)
    {
        Point2D p1 = new Point2D(2, 3);
        Point3D p2 = new Point3D(2);
        Point3D p3 = new Point3D(1, 2, 2);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
    }
}