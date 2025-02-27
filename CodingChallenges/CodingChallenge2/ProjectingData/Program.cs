namespace ProjectingData;

using System.Linq;

public class Student
{
    public string Name { get; set; }
    public string Subject { get; set; }
    public int Grade { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projecting Data with LINQ:");
        
        var students = new List<Student>
        {
            new Student { Name = "Mike", Subject = "Math", Grade = 85 },
            new Student { Name = "Emma", Subject = "English", Grade = 90 },
            new Student { Name = "Liam", Subject = "Math", Grade = 78 },
            new Student { Name = "Sophia", Subject = "Science", Grade = 88 }
        };

        var result = students
            .Where(s => s.Grade > 80)
            .Select(s => new { s.Name, s.Subject }).ToList();
        
        foreach (var item in result)
        {
            Console.WriteLine($"Name: {item.Name}, Subject: {item.Subject}");
        }
    }
}