namespace CodingChallenge1;

public interface IShape
{
    public double CalculateArea();
}

public class Circle : IShape
{
    private double radius;

    public double Radius
    {
        get
        {
            return radius;
        }
        set
        {
            radius = value;
        }
    }

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * (radius * radius);
    }
}

public class Rectangle : IShape
{
    private double length;
    private double width;

    public double Length
    {
        get
        {
            return length;
        }
        set
        {
            length = value;
        }
    }

    public double Width
    {
        get { return length; }
        set { length = value; }
    }

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double CalculateArea()
    {
        return length * width;
    }
}

public class Square : IShape
{
    private double side;

    public double Side
    {
        get { return side; }
        set { side = value; }
    }

    public Square(double side)
    {
        this.side = side;
    }

    public double CalculateArea()
    {
        return side * side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IShape[] shapes = new IShape[3];
        shapes[0] = new Circle(5);
        shapes[1] = new Rectangle(2, 3);
        shapes[2] = new Square(10);

        foreach (IShape shape in shapes)
        {
            Console.WriteLine("Area of " + shape.GetType().ToString().Split('.')[1] + ": " + shape.CalculateArea());
        }
    }
}