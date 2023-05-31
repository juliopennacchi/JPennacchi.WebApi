using JPennacchi.Application.DTOs;
using JPennacchi.Domain.Entities;

namespace JPennacchi.Application.RequestReponse.Documento
{
    public class ObterDocumentoRequest
    {
        public string Proprietario { get; set; }
        public TipoDocumento TipoDocumento { get; set; }

        //public ObterDescricaoResult ObterResultado(int tipoDocumento)
        //{
        //    var result = new ObterDescricaoResult { IsValid = false, Message = "Inválido" };
            
        //    if (tipoDocumento == 1)
        //    {
        //        result.IsValid = true;
        //        result.Message = null;
        //    }

        //    return result;
        //}
    }

    public class ObterDescricaoResult
    {
        public bool IsValid { get; set; }
        public string Message { get; set; }
    }
}
