using Microsoft.AspNetCore.Http;

namespace JPennacchi.Application.Services.Interfaces
{
    public interface IStorageService
    {
        Task<string> SaveFile(IFormFile file);
    }
}
