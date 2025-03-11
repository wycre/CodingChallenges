using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductInventorySystem
{
    // Product Class with Nullable Types
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; } 
        public int? WarrantyPeriod { get; set; }

        public Product(string productName, decimal price, decimal? discount = null, int? warrantyPeriod = null)
        {
            ProductName = productName;
            Price = price;
            Discount = discount;
            WarrantyPeriod = warrantyPeriod;
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product: {ProductName}, Price: {Price:C}");
            if (Discount.HasValue)
                Console.WriteLine($"Discount: {Discount:C}");
            else
                Console.WriteLine("No Discount");

            if (WarrantyPeriod.HasValue)
                Console.WriteLine($"Warranty: {WarrantyPeriod} months");
            else
                Console.WriteLine("No Warranty");
        }
    }

    // Inventory Class (Generic)
    public class Inventory<T> where T : Product
    {
        private List<T> products;

        public Inventory()
        {
            products = new List<T>();
        }

        public void AddProduct(T product)
        {
            products.Add(product);
        }

        public IEnumerable<T> GetProductsWithDiscount()
        {
            return products.Where(p => p.Discount.HasValue);
        }

        public IEnumerable<T> GetProductsWithWarranty()
        {
            return products.Where(p => p.WarrantyPeriod.HasValue);
        }

        public void DisplayInventory()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
                return;
            }

            foreach (var product in products)
            {
                product.DisplayProductInfo();
                Console.WriteLine();
            }
        }
    }

    // Main Program to Test the System
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of different products
            var laptop = new Product("Laptop", 1000, 150, 24);  // Product with discount and warranty
            var smartphone = new Product("Smartphone", 800, null, 12);  // Product with warranty, no discount
            var headphones = new Product("Headphones", 150);  // Product with no discount and no warranty

            // Create an inventory variable to store products: type Inventory that accepts Product as generic type, should be initialized with new Inventory<Product>()
            var inventory = new Inventory<Product>();

            // Add products to inventory
            inventory.AddProduct(laptop);
            inventory.AddProduct(smartphone);
            inventory.AddProduct(headphones);

            // Display all products in the inventory
            Console.WriteLine("Full Inventory:");
            inventory.DisplayInventory();

            // Get and display products with discount
            Console.WriteLine("\nProducts with Discount:");
            var discountedProducts = inventory.GetProductsWithDiscount();
            foreach (var product in discountedProducts)
            {
                product.DisplayProductInfo();
                Console.WriteLine();
            }

            // Get and display products with warranty
            Console.WriteLine("\nProducts with Warranty:");
            var productsWithWarranty = inventory.GetProductsWithWarranty();
            foreach (var product in productsWithWarranty)
            {
                product.DisplayProductInfo();
                Console.WriteLine();
            }
        }
    }
}