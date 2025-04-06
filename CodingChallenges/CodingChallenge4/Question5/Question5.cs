using System;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;
public class AsyncFileDownloader
{
    private static readonly HttpClient client = new HttpClient();
    // Asynchronous method to download a large file
    public async Task DownloadFileAsync(string url, string destinationPath)
    {
        HttpResponseMessage response = null;
        FileStream fileStream = null;
        Stream stream = null;
        try
        {

            // Add headers to avoid 403 Forbidden errors 
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");

            Console.WriteLine("Starting file download...");
            // Send the GET request asynchronously
            response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
            
            // Ensure a successful response
            response.EnsureSuccessStatusCode();
            
            // Open a stream to write the downloaded file to disk
            fileStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write, FileShare.None);
            
            // Open a stream to read the downloaded content
            stream = await response.Content.ReadAsStreamAsync();
            
            // Read and write the file in chunks to avoid high memory usage
            await stream.CopyToAsync(fileStream);
            Console.WriteLine("File downloaded successfully!");
        }
        catch (HttpRequestException e)
        {
            // Handle HTTP request errors
            Console.WriteLine($"Error during HTTP request: {e.Message}");
        }
        catch (IOException e)
        {
            // Handle file I/O errors (e.g., permission issues, disk full)
            Console.WriteLine($"Error writing to file: {e.Message}");
        }
        catch (Exception e)
        {
            // Handle any other unexpected errors
            Console.WriteLine($"Unexpected error: {e.Message}");
        }
        finally
        {
            // Explicitly dispose of resources
            if (stream != null)
                stream.Dispose();
            if (fileStream != null)
                fileStream.Dispose();
            if (response != null)
                response.Dispose();
        }
    }
    public static async Task Main(string[] args)
    {
        var downloader = new AsyncFileDownloader();
        string fileUrl = "http://ipv4.download.thinkbroadband.com/1GB.zip";
        string destinationPath = "1GB.zip"; // Path to save the file locally
        
        // Start the asynchronous download
        await downloader.DownloadFileAsync(fileUrl, destinationPath);
    }
}

// The main difference with Question 5 and Question 4 is that in 5, we explicity handle the resources which are required to complete the task
// In Question 4, we use the `using` keyword to implicitly handle errors and dispose of the resources when we are done with them. 
// but in Question 5 we need to explicitly handle any exceptions that come up and dispose of the resources when exiting the main code block.
// Overall, this makes Question 4 easier to read and less prone to programmer error