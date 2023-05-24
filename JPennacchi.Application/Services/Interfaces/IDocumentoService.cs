using JPennacchi.Application.RequestReponse.Documento;
using JPennacchi.Application.RequestResponse.Documento;

namespace JPennacchi.Application.Services.Interfaces
{
    public interface IDocumentoService
    {
        Task<ObterDocumentoResponse> ObterDocumentoAsync(ObterDocumentoRequest request);
    }
}
