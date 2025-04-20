using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void Main()
    {
        var items = new List<int>();
        for (int i = 0; i < 100; i++) items.Add(i);

        // create your cancellation token (name it cts)
        var cts = new CancellationTokenSource();

        // Cancel after 1 second, using Task.Run and Thread.Sleep(1000), also print a message saying cancelling
        Task.Run(() =>
        {
            Thread.Sleep(1000);
            Console.WriteLine("Cancelling...");
            cts.Cancel();
        });
    try
        {
            var options = new ParallelOptions
            {
                CancellationToken = cts.Token,
                MaxDegreeOfParallelism = 4  // Parallelism capped for consistency across different core counts
            };


            Console.WriteLine("Beginning process, press any key to cancel:");
            // create your parallel for each loop here, pass items and define new ParallelOptions with CancellationToken initialized with cts.Token, and also item that should resolve to the following
            Parallel.ForEach(items, options, item  => 
            {    
                // Simulate work
                Console.WriteLine($"Processing item {item}");
                Thread.Sleep(200); // simulate work delay
                                   // If cancellation is requested, this will throw
                cts.Token.ThrowIfCancellationRequested();
            });
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Operation was cancelled.");
        }
        Console.WriteLine("Done.");
    }
}