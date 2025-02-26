namespace CodingAssignment1;

using System.Linq;

/// <summary>
/// Abstract class representing a Person
/// </summary>
abstract class Person
{
    #region Properites
    
    public abstract string FirstName { get; set; }
    public abstract string LastName { get; set; }
    public abstract int Age { get; set; }

    #endregion
    
    #region Methods

    /// <summary>
    /// Returns the full name
    /// </summary>
    /// <returns></returns>
    public abstract string GetFullName();

    #endregion
}

/// <summary>
/// When the inheritor is enrollable
/// </summary>
interface IEnrollable
{
    public void EnrollInCourse(Course course);
}

/// <summary>
/// A Student, Implements the Person class and IEnrollable interface
/// </summary>
class Student : Person, IEnrollable
{
    #region Fields

    private string firstName;
    private string lastName;
    private int age;

    private List<Course> enrolledCourses = new List<Course>();
    
    #endregion
    
    #region Properties

    public override string FirstName
    {
        get { return firstName;}
        set { firstName = value; }
    }
    public override string LastName
    {
        get { return lastName;}
        set { lastName = value; }
    }
    public override int Age
    {
        get { return age;}
        set { age = value; }
    }
    
    public List<Course> EnrolledCourses
    {
        get { return enrolledCourses; }
    }
    
    #endregion
    
    #region Methods

    /// <summary>
    /// Returns the full name of the Student
    /// </summary>
    /// <returns>string representing the full name of the Student</returns>
    public override string GetFullName()
    {
        return firstName + " " + lastName;
    }

    /// <summary>
    /// Enrolls this student in a Course
    /// </summary>
    /// <param name="course">The Course to enroll into</param>
    public void EnrollInCourse(Course course)
    {
        enrolledCourses.Add(course);
    }
    
    #endregion
}

/// <summary>
/// A Course
/// </summary>
class Course
{
    #region Fields

    private string courseName;
    private int credits;
    
    #endregion

    #region Properties

    public string CourseName
    {
        get { return courseName;}
        set { courseName = value; }
    }
    public int Credits
    {
        get { return credits;}
        set { credits = value; }
    }

    #endregion
    
}

/// <summary>
/// Manages courses and students
/// </summary>
class CourseManagementSystem
{
    #region Fields

    private List<Course> allCourses;
    private List<Student> allStudents;

    #endregion

    #region Methods

    public CourseManagementSystem()
    {
        allCourses = new List<Course>();
        allStudents = new List<Student>();
    }


    /// <summary>
    /// Adds a Course to the system
    /// </summary>
    /// <param name="course">A Course</param>
    public void AddCourse(Course course)
    {
        allCourses.Add(course);
    }

    /// <summary>
    /// Adds a Student to the system
    /// </summary>
    /// <param name="student">A Student</param>
    public void AddStudent(Student student)
    {
        allStudents.Add(student);
    }

    /// <summary>
    /// Gets a list of students enrolled in the named course
    /// </summary>
    /// <param name="courseName">The string name of the Course</param>
    /// <returns>List of Students</returns>
    public List<Student> GetStudentsEnrolledInCourse(string courseName)
    {
        return allStudents.Where(student => student.EnrolledCourses.Any(course => course.CourseName == courseName)).ToList();
    }

    /// <summary>
    /// Obtains the average number of credits taken by all students registered to this object
    /// </summary>
    /// <returns>double - average of Credits taken</returns>
    public double GetAverageCreditsEnrolledByStudents()
    {
        if (allStudents.Any())
        {
            return allStudents.Average(student => student.EnrolledCourses.Sum(course => course.Credits));
        }
        return 0.0;
    }

    #endregion
}

/// <summary>
/// Program to test the above classes
/// </summary>
class Program
{
    static void Main()
    {
        // Create courses
        Course math101 = new Course { CourseName = "Math 101", Credits = 3 };
        Course cs101 = new Course { CourseName = "CS 101", Credits = 4 };
        Course history101 = new Course { CourseName = "History 101", Credits = 3 };
        // Create students
        Student student1 = new Student { FirstName = "John", LastName = "Doe", Age = 20 };
        Student student2 = new Student { FirstName = "Jane", LastName = "Smith", Age = 22 };
        Student student3 = new Student { FirstName = "Alice", LastName = "Brown", Age = 21 };
        // Enroll students in courses
        student1.EnrollInCourse(math101);
        student1.EnrollInCourse(cs101);
        student2.EnrollInCourse(cs101);
        student2.EnrollInCourse(history101);
        student3.EnrollInCourse(math101);
        student3.EnrollInCourse(history101);
        // Create the course management system and add data
        CourseManagementSystem cms = new CourseManagementSystem();
        cms.AddCourse(math101);
        cms.AddCourse(cs101);
        cms.AddCourse(history101);
        cms.AddStudent(student1);
        cms.AddStudent(student2);
        cms.AddStudent(student3);
        
        
        // Get students enrolled in "CS 101"
        var studentsInCS101 = cms.GetStudentsEnrolledInCourse("CS 101");
        Console.WriteLine("Students enrolled in CS 101:");
        foreach (var student in studentsInCS101)
        {
            Console.WriteLine(student.GetFullName());
        }
        
        // Get students enrolled in Math 101
        var studentsInMath101 = cms.GetStudentsEnrolledInCourse("Math 101");
        Console.WriteLine("Students enrolled in Math 101:");
        foreach (var student in studentsInCS101)
        {
            Console.WriteLine(student.GetFullName());
        }
        
        // Get students enrolled in History 101
        var studentsInHistory101 = cms.GetStudentsEnrolledInCourse("History 101");
        Console.WriteLine("Students enrolled in History 101:");
        foreach (var student in studentsInCS101)
        {
            Console.WriteLine(student.GetFullName());
        }
        
        // Use LINQ to get the average credits per student
        var averageCredits = cms.GetAverageCreditsEnrolledByStudents();
        Console.WriteLine($"\nAverage credits per student: {averageCredits:F2}");
    }
}