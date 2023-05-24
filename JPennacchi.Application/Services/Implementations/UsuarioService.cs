using JPennacchi.Application.Services.Interfaces;
using JPennacchi.Domain.Entities;
using JPennacchi.Infra.Repository.Repositories.Interfaces;

namespace JPennacchi.Application.Services.Implementations
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<Usuario> GetAsync(string nome, string senha) =>
            await _usuarioRepository.GetAsync(nome, senha);
    }
}
