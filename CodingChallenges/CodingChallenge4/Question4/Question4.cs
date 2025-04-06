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
        Console.WriteLine("Starting file download...");

        // Add headers to avoid 403 Forbidden errors 
        client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");

        // Send the GET request asynchronously
        using (HttpResponseMessage response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
        {
            response.EnsureSuccessStatusCode(); // Ensure a successful response
            
            // Open a stream to write the downloaded file
            using (var fileStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                // Open a stream to read the downloaded content
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    // Read and write the file in chunks to avoid high memory usage
                    // await for stream.CopyToAsync(fileStream);
                    await stream.CopyToAsync(fileStream);
                    Console.WriteLine("File downloaded successfully!");
                }
            }
        }
    }

    public static async Task Main(string[] args)
    {
        var downloader = new AsyncFileDownloader();
        string fileUrl = "http://ipv4.download.thinkbroadband.com/1GB.zip"; // URL of the file to download 
        string destinationPath = "1GB.zip"; // Path to save the file locally

        // Start the asynchronous download
        await downloader.DownloadFileAsync(fileUrl, destinationPath);
    }
}