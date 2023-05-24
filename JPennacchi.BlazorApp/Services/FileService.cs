using Microsoft.AspNetCore.Components.Forms;

namespace JPennacchi.BlazorApp.Services
{
    public class FileService
    {
        private readonly HttpClient _clienthttpClient;
        public FileService(IHttpClientFactory httpClientFactory)
        {
            _clienthttpClient = httpClientFactory.CreateClient(nameof(FileService));
        }

        public async Task<string> UploadFile(IBrowserFile file)
        {
            byte[] bytes;
            using (Stream stream = file.OpenReadStream())
            {
                using MemoryStream memoryStream = new MemoryStream();
                await stream.CopyToAsync(memoryStream);
                bytes = memoryStream.ToArray();
            }

            var form = new MultipartFormDataContent
            {
                { new ByteArrayContent(bytes, 0, bytes.Length), "file", file.Name }
            };

            try
            {
                var response = await _clienthttpClient.PostAsync("api/file/upload", form);
                response.EnsureSuccessStatusCode();
                var filePath = await response.Content.ReadAsStringAsync();

                return $"Imagem salva em {filePath}";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
