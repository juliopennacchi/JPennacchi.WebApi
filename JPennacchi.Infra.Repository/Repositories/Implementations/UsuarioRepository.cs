using JPennacchi.Domain.Entities;
using JPennacchi.Infra.Repository.Repositories.Interfaces;

namespace JPennacchi.Infra.Repository.Repositories.Implementations
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Task<Usuario> GetAsync(string nome, string senha)
        {
            var usuarios = new List<Usuario> { 
                new Usuario {Id = 1, Nome= "joao", Senha = "joao", Role = "gerente"},
                new Usuario {Id = 1, Nome= "jose", Senha = "jose", Role = "funcionario"}
            };
            return Task.FromResult(usuarios.Where(u => u.Nome == nome && u.Senha == senha).FirstOrDefault());
        }
    }
}
