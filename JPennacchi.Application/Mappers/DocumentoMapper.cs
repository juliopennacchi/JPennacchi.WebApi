using JPennacchi.Application.DTOs;
using JPennacchi.Domain.Entities;

namespace JPennacchi.Application.Mappers
{
    public static class DocumentoMapper
    {
        public static DocumentoDto? Mapper(this Documento entity)
        {
            if (entity == null)
                return null;

            return new DocumentoDto
            {
                Numero = entity.Numero,
                TipoDocumento = entity.Tipo,
                Proprietario = entity.Proprietario
            };
        }
    }
}
