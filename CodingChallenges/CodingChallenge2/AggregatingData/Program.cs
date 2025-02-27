namespace AggregatingData;

using System.Linq;

public class Transaction
{
    public int TransactionId { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Aggregating Data with LINQ:");
        
        var transactions = new List<Transaction>
        {
            new Transaction { TransactionId = 1, Amount = 100, Date = DateTime.Now.AddDays(-5) },
            new Transaction { TransactionId = 2, Amount = 200, Date = DateTime.Now.AddDays(-10) },
            new Transaction { TransactionId = 3, Amount = 300, Date = DateTime.Now.AddDays(-40) },
            new Transaction { TransactionId = 4, Amount = 50, Date = DateTime.Now.AddDays(-20) }
        };

        var result = transactions
            .Where(t => t.Date > DateTime.Now.AddDays(-30))
            .Sum(t => t.Amount);
        
        Console.WriteLine($"Total amount of transactions in the last 30 days: {result:C}");
    }
}