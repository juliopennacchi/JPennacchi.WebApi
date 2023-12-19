using JPennacchi.Application.RequestReponse.Documento;
using JPennacchi.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using JPennacchi.WebApi.Extensions;

namespace JPennacchi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentoController : ControllerBase
    {
        private readonly IDocumentoService service;
        public DocumentoController(IDocumentoService service)
        {
            this.service = service;
        }

        [Route("Obter")]
        [HttpGet]
        [Consumes("application/json")]
        [ProducesResponseType(200)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult ObterDocumentoPorTipoAsync([FromBody] ObterDocumentoRequest request)
        {
            var response = service.ObterDocumentoAsync(request).Result;

            return this.GetResponse(response);
        }
    }
}