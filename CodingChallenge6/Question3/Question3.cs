using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Question3
{
    static void Main()
    {
        // List of numbers to compute factorials for
        var numbers = new List<int> { 10000, 15000, 12000, 13000, 16000, 17000, 18000, 20888, 20622, 18666, 21000, 22000, 23000, 24000, 25000 };  // Extra large numbers added to slow down full process

        // define your cts of type var with cancellation token.
        var cts = new CancellationTokenSource();

        // Simulate user cancelling after 2 seconds using Task.Run and Thread.Sleep(2000), also print a message saying user requested cancellation
        Stopwatch stopwatch = Stopwatch.StartNew();  // Add stopwatch for tracking time spent
        Task.Run(() =>
        {
            Thread.Sleep(2000);
            Console.WriteLine("Cancelling...");
            cts.Cancel();
        });

        try
        {
            //create your parallel for each loop with numbers, ParallelOptions having cancellation token and number that should resolve to the following
            var options = new ParallelOptions
            {
                CancellationToken = cts.Token,
                MaxDegreeOfParallelism = 4  // Parallelism capped for consistency across different core counts
            };

            Parallel.ForEach(numbers, options, number =>
            {
                Console.WriteLine($"Calculating factorial of {number} on thread {Thread.CurrentThread.ManagedThreadId}...");

                // define result of type var and initialize it using the Factorial function and sent the number and cancellation token to it.
                var result = CalculateFactorial(number, cts.Token);

                Console.WriteLine($"Factorial of {number} computed (length:{result.ToString().Length} digits).");
            });
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Factorial computation was cancelled.");
        }
        stopwatch.Stop();
        Console.WriteLine($"Total elapsed time: {stopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine("Done.");
    }

    // Uses BigInteger for large factorials and checks for cancellation during the loop
    static BigInteger CalculateFactorial(int n, CancellationToken token)
    {
        BigInteger result = 1;
        for (int i = 2; i <= n; i++)
        {
            token.ThrowIfCancellationRequested();
            result *= i;
        }
        return result;
    }
}