using System;
using System.Threading;
using System.Threading.Tasks;
class Program
{
    // Simulates a long-running task that checks for cancellation
    static async Task RunWorkAsync(CancellationToken token)
    {
        Console.WriteLine("Work started...\n");
        for (int i = 1; i <= 10; i++)
        {
            token.ThrowIfCancellationRequested(); // Check if cancellation was requested
            Console.WriteLine($"Step {i}/10 in progress...");
            await Task.Delay(1000, token); // Simulate async work
        }
        Console.WriteLine("\nWork completed successfully.");
    }
    static async Task Main(string[] args)
    {
        using CancellationTokenSource cts = new CancellationTokenSource();
        Console.WriteLine("Press ENTER at any time to cancel the operation.\n");
        // Start the long-running task with the token:
        // define workTask of type Task, cann RunWorkAsyn and pass the cts.token to it.
        Task workTask;
        RunWorkAsync(cts.Token);
        // Wait for either the Enter key or the work to complete:
        // define cancelTask of type Task
        Task cancelTask;
        Task.Run(canceltask, () => ConsoleReadLine())
        // initialize it with Task.Run and pass () => ConsoleReadLine() to it.
        // define finishedTask of type Task
        // initialize it with await for Task.WhenAny and pass workTask and cancelTask to it
        // If Enter was pressed first, cancel the operation
        if (finishedTask == cancelTask)
        {
            // call Cancel() method from cts (like cts.?)
            Console.WriteLine("\nCancellation requested by user.");
        }
        // Await the work task to observe any exceptions
        try
        {
        // await for workTask
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("\nOperation was cancelled.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nUnexpected error: {ex.Message}");
        }
        Console.WriteLine("\nProgram has ended. Press any key to exit.");
        Console.ReadKey();
    }
}