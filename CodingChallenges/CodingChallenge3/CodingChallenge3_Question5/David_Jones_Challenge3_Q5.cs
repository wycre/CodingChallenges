using System;

namespace CodingChallenge3_Question5
{
    // Library class with an event
    public class Library
    {
        // Complete this part: Declare an event: should be public, type Action with string as generic type, call it BookAdded
        public Action<string> BookAdded; 

        // Method to add a book and trigger the event
        public void AddBook(string bookName)
        {
            Console.WriteLine($"Adding book: {bookName}");
            OnBookAdded(bookName);
        }

        // Method to trigger the event
        protected virtual void OnBookAdded(string bookName)
        {
            // complete this part: If there are subscribers, invoke the BookAdded event, pass bookname to it and make sure it is nullable
            BookAdded?.Invoke(bookName);
        }
    }

    // User class subscribing to the event
    public class User
    {
        public void OnBookAdded(string bookName)
        {
            Console.WriteLine("User: A new book has been added to the library!");
        }
    }

    // Admin class subscribing to the event
    public class Admin
    {
        public void OnBookAdded(string bookName)
        {
            Console.WriteLine($"Admin: Book '{bookName}' has been added.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Library, User, and Admin
            Library library = new Library();
            User user = new User();
            Admin admin = new Admin();

            // Subscribe to the BookAdded event
            library.BookAdded += user.OnBookAdded;
            library.BookAdded += admin.OnBookAdded;

            // Add a new book to the library, triggering the event
            library.AddBook("C# Programming Guide");

            // Output:
            // Adding book: C# Programming Guide
            // User: A new book has been added to the library!
            // Admin: Book 'C# Programming Guide' has been added.
        }
    }
}