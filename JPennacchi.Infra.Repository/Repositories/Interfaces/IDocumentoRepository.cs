using JPennacchi.Domain.Entities;

namespace JPennacchi.Infra.Repository.Repositories.Interfaces
{
    public interface IDocumentoRepository
    {
        Task<Documento> ObterDocumentoAsync(string proprietario, TipoDocumento tipo);
    }
}
