namespace CodingChallenge2;

using System.Linq;

class Employee
{
    private string name;
    private int age;
    private string department;
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Department
    {
        get { return department; }
        set { department = value; }
    }
}

public class BasicFiltering
{
    static void Main(string[] args)
    {
        var employees = new List<Employee>
        {
            new Employee { Name = "John", Age = 29, Department = "HR" },
            new Employee { Name = "Sara", Age = 22, Department = "IT" },
            new Employee { Name = "Alice", Age = 35, Department = "Finance" },
            new Employee { Name = "Bob", Age = 28, Department = "Marketing" },
            new Employee { Name = "Eve", Age = 40, Department = "IT" }
        };
        Console.WriteLine("Basic Filtering:");

        var result = employees
            .Where(e => e.Age > 25)
            .OrderByDescending(e => e.Age)
            .Select(e => new { e.Name, e.Department })
            .ToList();

        foreach (var e in result)
        {
            Console.WriteLine($"{e.Name}: {e.Department}");
        }
    }
}