using System;

namespace Word_Scrabble.src.Helpers
{
    public class FileReader
    {
        private FileDownloader fileDownloader;
        private readonly string filePath = @"Docs\words_alpha.txt";

        public FileReader()
        {
            fileDownloader = new FileDownloader();
        }
        public string[] readFile()
        {
            string path;
            path = Path.GetFullPath(filePath);
            Console.WriteLine(path);
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                return lines;
            }
            else
            {
                try
                {
                    Console.WriteLine("Attempting to download file");
                    Task<string> task = fileDownloader.DownloadFileAsync();
                    path = task.Result;
                    if (File.Exists(path))
                    {
                        Console.WriteLine("File downloaded");
                        string[] lines = File.ReadAllLines(path);
                        return lines;
                    }
                }
                catch (Exception ex)
                {

                    throw new Exception($"Could not download File does not exist : {ex.Message}");
                }
                throw new Exception("File does not exist");
            }
        }
    }
}
