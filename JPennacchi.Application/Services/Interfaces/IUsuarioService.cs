using JPennacchi.Domain.Entities;

namespace JPennacchi.Application.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario> GetAsync(string nome, string senha);
    }
}
