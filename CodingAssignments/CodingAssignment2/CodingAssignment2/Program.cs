using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Prepare a collection of numbers to process: define numbers list with int value (1 - 10)
        List<int> numbers = new List<int>([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);

        CancellationTokenSource cts = new CancellationTokenSource();

        // Get reference to Cancellation Token in cts
        CancellationToken cancellationToken = cts.Token;

        // Start Cancellation Listening Task
        // Don't use await to let this task run in the background
        Task.Run(() =>
        {
            Console.WriteLine("Press any key to cancel the operation...");
            Console.ReadKey();
            Console.WriteLine();  // Prevent future writes from using the same line as the input
            cts.Cancel();
        });

        // Run Process
        try
        {
            await ProcessNumbersAsync(numbers, cancellationToken);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Operation was cancelled");
        }
    }

    /// <summary>
    /// Simulates parallel processing of numbers
    /// </summary>
    /// <param name="numbers">List of integers</param>
    /// <param name="cancellationToken">cancellation token for this task</param>
    static async Task ProcessNumbersAsync(List<int> numbers, CancellationToken cancellationToken)
    {
        await Task.Run(() =>
        {
            var options = new ParallelOptions
            {
                CancellationToken = cancellationToken,
                MaxDegreeOfParallelism = 2  // Limit parallelism for more consistent testing
            };

            // Parallel process the input
            Parallel.ForEach(numbers, options, number =>
            {
                // Simulate number processing
                Console.WriteLine($"Processing {number}...");
                Thread.Sleep(1000);
                
                // Handle task cancellation
                if (cancellationToken.IsCancellationRequested)
                {
                    Console.WriteLine($"Operation cancelled before processing {number}");
                    cancellationToken.ThrowIfCancellationRequested();
                }
                
                // Write task result
                Console.WriteLine($"The square of {number} is {number * number}");
            });
        });
    }
}
