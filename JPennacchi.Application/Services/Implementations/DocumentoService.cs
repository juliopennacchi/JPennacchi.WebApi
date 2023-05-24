using FluentValidation;
using JPennacchi.Application.DTOs;
using JPennacchi.Application.Mappers;
using JPennacchi.Application.RequestReponse.Documento;
using JPennacchi.Application.RequestResponse.Documento;
using JPennacchi.Application.Services.Interfaces;
using JPennacchi.Infra.Repository.Repositories;
using JPennacchi.Infra.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPennacchi.Application.Services.Implementations
{
    public class DocumentoService : IDocumentoService
    {
        private readonly IValidator<ObterDocumentoRequest> obterDocumentRequestValidator;
        private readonly IDocumentoRepository documentoRepository;
        public DocumentoService(IValidator<ObterDocumentoRequest> obterDocumentRequestValidator,
            IDocumentoRepository documentoRepository)
        {
            this.obterDocumentRequestValidator = obterDocumentRequestValidator;
            this.documentoRepository = documentoRepository;
        }

        public async Task<ObterDocumentoResponse> ObterDocumentoAsync(ObterDocumentoRequest request)
        {
            var response = new ObterDocumentoResponse();

            try
            {
                //validar request
                var result = await obterDocumentRequestValidator.ValidateAsync(request);

                if (!result.IsValid)
                {
                    response.AddError(result.Errors);
                    return response;
                }

                //obter documento
                var documento = await documentoRepository.ObterDocumentoAsync(request.Proprietario, request.TipoDocumento);
                response.Documento = documento?.Mapper();

                return response;
            }
            catch (Exception ex)
            {
                response.AddError(ex);
                return response;
            }
        }
    }
}
