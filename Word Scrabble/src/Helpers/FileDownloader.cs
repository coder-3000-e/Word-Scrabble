using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Word_Scrabble.src.Helpers
{
    public class FileDownloader
    {
        private readonly string githubUrl = "https://github.com/dwyl/english-words/raw/master/words_alpha.txt";

        public async Task<string> DownloadFileAsync()
        {
            using HttpClient httpClient = new();
            try
            {
                var response = await httpClient.GetAsync(githubUrl);

                if (response.IsSuccessStatusCode)
                {
                    string tempFilePath = Path.GetTempFileName();
                    using (Stream stream = await response.Content.ReadAsStreamAsync())
                    using (FileStream fileStream = File.Create(tempFilePath))
                    {
                        await stream.CopyToAsync(fileStream);
                        return tempFilePath;
                    }
                }
                else
                {
                    throw new Exception($"Error downloading file: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error downloading file: {ex.Message}");
            }
        }
    }
}
