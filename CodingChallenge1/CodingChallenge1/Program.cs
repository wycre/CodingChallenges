namespace CodingChallenge1;

#region Extra Classes

/// <summary>
/// Interface for a shape
/// </summary>
public interface IShape
{
    public double CalculateArea();
}

/// <summary>
/// A Circle, Implements IShape
/// </summary>
public class Circle : IShape
{
    #region Fields
    // the radius of this circle
    private double radius;
    #endregion

    #region Properties
    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }
    #endregion

    #region Methods
    /// <summary>
    /// Makes a new Circle
    /// </summary>
    /// <param name="radius">The radius of the Circle</param>
    public Circle(double radius)
    {
        this.radius = radius;
    }

    /// <summary>
    /// Calculates the area of this Circle based on the set radius
    /// </summary>
    /// <returns>The area of this Circle, as a double</returns>
    public double CalculateArea()
    {
        return Math.PI * (radius * radius);
    }
    #endregion
}

/// <summary>
/// A Rectangle, implements IShape
/// </summary>
public class Rectangle : IShape
{
    #region Fields
    private double length;
    private double width;
    #endregion

    #region Properties
    public double Length
    {
        get { return length; }
        set { length = value; }
    }
    

    public double Width
    {
        get { return length; }
        set { length = value; }
    }
    #endregion

    #region Methods
    /// <summary>
    /// Makes a new Rectangle
    /// </summary>
    /// <param name="length">The length of the Rectangle</param>
    /// <param name="width">The width of the Rectangle</param>
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    /// <summary>
    /// Calculates the area of this Rectangle based on the set dimensions
    /// </summary>
    /// <returns>The area of this Rectangle, as a double</returns>
    public double CalculateArea()
    {
        return length * width;
    }
    #endregion
}

/// <summary>
/// A Square, implements IShape
/// </summary>
public class Square : IShape
{
    #region Fields
    private double side;
    #endregion

    #region Properties
    public double Side
    {
        get { return side; }
        set { side = value; }
    }
    #endregion

    #region Methods
    /// <summary>
    /// Makes a new Square
    /// </summary>
    /// <param name="side">The side length of the Square</param>
    public Square(double side)
    {
        this.side = side;
    }
    
    /// <summary>
    /// Calculates the area of this Square based on the set side length
    /// </summary>
    /// <returns>The area of this Square, as a double</returns>
    public double CalculateArea()
    {
        return side * side;
    }
    #endregion
}

#endregion

// Test program for the above classes
class Program
{
    static void Main(string[] args)
    {
        // initialize the array with the shapes
        IShape[] shapes = new IShape[] { new Circle(5), new Rectangle(4, 6), new Square(4) };

        // Print the shape areas
        foreach (IShape shape in shapes)
        {
            Console.WriteLine("Area of " + shape.GetType().Name + ": " + shape.CalculateArea());
        }
    }
}