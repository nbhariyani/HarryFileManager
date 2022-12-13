using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace HarryFileManager
{
    internal class FileDeletion
    {
        public async Task DeleteFiles(string filePath, CancellationTokenSource cts)
        {

            // The path of the file to delete
            //string filePath = "C:\\MyFiles\\TextFile.txt";

            // Create a CancellationTokenSource to cancel the operation if needed
            //CancellationTokenSource cts = new CancellationTokenSource();

            // Delete the file asynchronously
            //await File.Delete(filePath, cts.Token);

            Console.WriteLine("File deleted successfully.");
        }
    }
}
