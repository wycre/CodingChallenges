namespace CodingPractice1;

class Program
{
    
    // Declare delegate type
    public delegate int Calculation(int a, int b);
        
    // Methods that match the delegate signature
    public static int Add(int a, int b)
    {
        Console.WriteLine(a + b);
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        Console.WriteLine(a * b);
        return a * b;
    }
    
    static void Main(string[] args)
    {
        // Instantiate the delgate and point it to add and multiply
        Calculation calc = Add;

        calc += Multiply;

        calc(2, 3);
    }
}