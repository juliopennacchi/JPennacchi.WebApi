using JPennacchi.Domain.Entities;
using JPennacchi.Infra.Repository.Repositories.Interfaces;

namespace JPennacchi.Infra.Repository.Repositories.Implementations
{
    public class DocumentoRepository : IDocumentoRepository
    {
        public async Task<Documento> ObterDocumentoAsync(string proprietario, TipoDocumento tipo)
        {
            return await Task.FromResult( new Documento { Id = Guid.NewGuid(), Numero = "123", Proprietario= proprietario, Tipo=tipo });
        }
    }
}
