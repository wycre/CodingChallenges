using System;
using System.Collections.Generic;

namespace BookstoreManagementSystem
{
    // Book Class with Properties
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public Book(string title, string author, decimal price, int stockQuantity)
        {
            Title = title;
            Author = author;
            Price = price;
            StockQuantity = stockQuantity;
        }

        // Method to display book information
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Price: {Price:C}, Stock Quantity: {StockQuantity}");
        }
    }

    // Bookstore Class with Methods to Add Books, Update Stock, and Display Books
    public class Bookstore
    {
        private List<Book> books = new List<Book>();

        // Method to add a book to the bookstore
        public void AddBook(Book book)
        {
            // Putting try-catch blocks inside the method that throws the exception is nonsense, I have moved them to main - David
            // A callee should never handle its own exceptions, doing so is counter-productive to the purpose of exceptions

            // Check if the book already exists in the bookstore
            if (books.Exists(b => b.Title == book.Title))
            {
                throw new InvalidOperationException("Book already exists in the bookstore.");
            }

            if (book.Price < 0)
            {
                throw new InvalidOperationException("Book Price cannot be negative.");
            }

            // Add the book to the bookstore
            books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added successfully.");
        }

        // Method to update the stock of a book
        public void UpdateStock(string title, int quantity)
        {
            // Validate the quantity
            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity), "Stock quantity cannot be negative.");
            }

            // Find the book by title
            var book = books.Find(b => b.Title == title);
            if (book == null)
            {
                throw new KeyNotFoundException("Book not found in the bookstore.");
            }

            // Update the stock quantity
            book.StockQuantity = quantity;
            Console.WriteLine($"Stock updated for '{book.Title}' to {book.StockQuantity}.");
        }

        // Method to display all books in the bookstore
        public void DisplayBooks()
        {
            if (books.Count == 0)
            {
                throw new InvalidOperationException("No books in the bookstore.");
            }

            Console.WriteLine("\nBooks in the bookstore:");
            foreach (var book in books)
            {
                book.DisplayBookInfo();
            }
        }
    }

    // Main Program to Test the System
    class Program
    {
        static void Main(string[] args)
        {
            // Create a bookstore
            Bookstore bookstore = new Bookstore();

            // Create some book objects
            Book book1 = new Book("The Catcher in the Rye", "J.D. Salinger", 15.99m, 10);
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 18.50m, 5);
            Book book3 = new Book("1984", "George Orwell", -10.00m, 7); // Invalid price for testing

            // Try adding books to the bookstore
            bookstore.AddBook(book1);
            bookstore.AddBook(book2);

            try
            {
                bookstore.AddBook(book1); // This should throw an exception (duplicate book)
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                bookstore.AddBook(book3); // This should throw an exception (invalid price)
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Try updating the stock
            bookstore.UpdateStock("The Catcher in the Rye", 15); // Valid stock update

            try
            {
                bookstore.UpdateStock("To Kill a Mockingbird", -5); // Invalid stock update (negative quantity)
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                bookstore.UpdateStock("Non-Existent Book", 10); // Invalid book (not found)
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Display the books in the bookstore
            try
            {
                bookstore.DisplayBooks();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}