namespace JoiningData;

using System.Linq;

public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
}

public class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public decimal Amount { get; set; }
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Joining Data with LINQ:");
        
        var customers = new List<Customer>
        {
            new Customer { CustomerId = 1, Name = "John" },
            new Customer { CustomerId = 2, Name = "Sara" },
            new Customer { CustomerId = 3, Name = "Alice" }
        };
        var orders = new List<Order>
        {
            new Order { OrderId = 101, CustomerId = 1, Amount = 250 },
            new Order { OrderId = 102, CustomerId = 2, Amount = 450 },
            new Order { OrderId = 103, CustomerId = 1, Amount = 300 }
        };

        var result = customers.Join(orders, 
            customer => customer.CustomerId, order => order.CustomerId, 
            (customer, order) => new
            {
                customer.Name, 
                order.OrderId, 
                order.Amount
            }).ToList();    
        
        foreach (var item in result)
        {
            Console.WriteLine($"Customer: {item.Name}, OrderId: {item.OrderId}, Amount:{item.Amount:C}");
        }
    }
}