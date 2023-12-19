using JPennacchi.Domain.Entities;

namespace JPennacchi.Application.RequestReponse.Documento
{
    public class ObterDocumentoRequest
    {
        public string? Proprietario { get; set; }
        public TipoDocumento? TipoDocumento { get; set; }
    }
}
