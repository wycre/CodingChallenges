namespace GroupingData;

using System.Linq;

class Product
{
    public string Category { get; set; }
    public decimal Price { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Grouping Data with LINQ:");
        
        var products = new List<Product>
        {
            new Product { Category = "Electronics", Price = 199.99M },
            new Product { Category = "Electronics", Price = 50.00M },
            new Product { Category = "Clothing", Price = 29.99M },
            new Product { Category = "Clothing", Price = 79.99M },
            new Product { Category = "Electronics", Price = 120.00M }
        };

        var result = products
            .GroupBy(p => p.Category)
            .Select(g => new
            {
                Category = g.Key,
                TotalPrice = g.Sum(p => p.Price)
            }).ToList();
        
        foreach (var item in result)
        {
            Console.WriteLine($"{item.Category}: {item.TotalPrice:C}");
        }
    }
}