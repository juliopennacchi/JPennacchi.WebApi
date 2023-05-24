using JPennacchi.Application.DTOs;

namespace JPennacchi.Application.RequestResponse.Documento
{
    public class ObterDocumentoResponse: Response
    {
        public DocumentoDto Documento { get; set; }
    }
}
