using JPennacchi.Domain.Entities;

namespace JPennacchi.Application.DTOs
{
    public class DocumentoDto
    {
        public string Proprietario { get; set; }
        public string Numero { get; set; }
        public TipoDocumento TipoDocumento { get; set; }

    }
}
