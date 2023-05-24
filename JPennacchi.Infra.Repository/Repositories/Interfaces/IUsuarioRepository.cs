using JPennacchi.Domain.Entities;

namespace JPennacchi.Infra.Repository.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> GetAsync(string nome, string senha);
    }
}
