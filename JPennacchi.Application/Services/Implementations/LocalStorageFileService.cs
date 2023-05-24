using JPennacchi.Application.Services.Interfaces;
using Microsoft.AspNetCore.Http;

namespace JPennacchi.Application.Services.Implementations
{
    public class LocalStorageFileService : IStorageService
    {
        public async Task<string> SaveFile(IFormFile file)
        {
            var path = @"C:\Storage\FilesImported";

            var fileToSavePath = Path.Combine(path, file.FileName);
            using (var fileStream = File.Create(fileToSavePath))
            {
                await file.CopyToAsync(fileStream);
            }

            return fileToSavePath;
        }
    }
}
