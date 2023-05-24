using JPennacchi.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JPennacchi.WebApi.Controllers
{
    [ApiController]
    [Route("api/file")]
    public class FileController : ControllerBase
    {
        private readonly IStorageService _localStorageService;
        public FileController(IStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        [HttpPost]
        [Route("upload")]
        public async Task<string> UploadFile([FromForm] IFormFile file) =>
            await _localStorageService.SaveFile(file);
        
    }
}