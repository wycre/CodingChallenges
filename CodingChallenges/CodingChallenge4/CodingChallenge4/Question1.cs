using System;
using System.Threading.Tasks;
public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
}
public class AsyncExample
{
    public async Task DownloadDataAsync()
    {
        Console.WriteLine("Starting Data Download");
        await Task.Delay(2000);
        Console.WriteLine("Data Download Completed");
    }

    public async Task<User> GetUserDetailsAsync(int userId)
    {
        Console.WriteLine($"Fetching details for user {userId}...");
        await Task.Delay(1000);
        return new User { Name = "John Doe", Age = 30 };
    }

    public async void ButtonClickHandlerAsync(Object sender, EventArgs e)
    {
        Console.WriteLine("Buton clicked, starting async operation...");
        await Task.Delay(1000);
        Console.WriteLine("Button click operation completed.");
    }


}
public class Program
{
    //define a public and static and async Main method with Task as return type
    public static async Task Main(string[] args)
    {
        //define "example" of type var and initialize it with a new AysncExample()
        var example = new AsyncExample();

        // 1. Calling the Task-returning method: example.DownloadDataAsync() with await
        await example.DownloadDataAsync();

        // 2. Calling the Task<T>-returning method: define user of type User and initialize it with example.GetUserDetailsAsync(1) with await
        User user = await example.GetUserDetailsAsync(1);
        Console.WriteLine($"User Details: Name = {user.Name}, Age = {user.Age}");

        // 3. Simulating an event handler: call example.ButtonClickHandlerAsync and pass null and EventArgs.Empty as parameters to it.
        // In a real scenario, this would be triggered by an actual button click
        example.ButtonClickHandlerAsync(null, EventArgs.Empty);

        // Wait for async operation to complete before exiting
        await Task.Delay(2000);



    }
}
